import {DatabaseHandler} from "../handlers/DatabaseHandler.js";
import {LoremIpsum} from "lorem-ipsum";

class Emisor {
    #rfc;
    #nombre;
    #regimenFiscal;
    #facAtrAdquiriente;

    #dbId;

    #lorem = new LoremIpsum({
        sentencesPerParagraph: {
            max: 8,
            min: 4
        },

        wordsPerSentence: {
            max: 16,
            min: 4
        }
    });

    /** Creates a new object of type CuentaTerceros
     */
    constructor() {
        this.#rfc = this.#MakeID(13, 1);
        this.#nombre = this.#lorem.generateWords(this.#GetRandomInt(3, 6));

        if (Math.random() < 0.5) {
            this.#facAtrAdquiriente = this.#MakeID(20, 2);
        }
    }

    async Populate() {
        let [regimenFiscal] = await DatabaseHandler.Query("SELECT id FROM c_regimen_fiscal ORDER BY RAND() LIMIT 1");
        this.#regimenFiscal = regimenFiscal.id;
    }

    #MakeID(length, type) {
        let result = '';
        let characters = '';
        switch (type) {
            case 1:
                characters = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789';
                break;
            case 2:
                characters = '0123456789';
                break;
            case 3:
                characters = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ';
                break;
            default:
                characters = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789';
                break;
        }

        let charactersLength = characters.length;
        for (let i = 0; i < length; i++ ) {
            result += characters.charAt(Math.floor(Math.random() *
                charactersLength));
        }
        return result;
    }

    #GetRandomInt(min = 0, max = 1) {
        return Math.floor(Math.random() * (max - min)) + min;
    }

    async SaveToDatabase() {
        let databaseID = await DatabaseHandler.Query("INSERT INTO emisores SET ?", [
            {
                rfc: this.#rfc,
                nombre: this.#nombre,
                regimen_fiscal: this.#regimenFiscal,
                fac_atr_adquiriente: this.#facAtrAdquiriente
            }
        ]);

        this.#dbId = databaseID.insertId;
    }

    GetDatabaseId() {
        return this.#dbId;
    }
}

export { Emisor };
