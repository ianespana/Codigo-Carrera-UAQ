import {DatabaseHandler} from "../handlers/DatabaseHandler.js";
import {LoremIpsum} from "lorem-ipsum";

class Receptor {
    #rfc;
    #nombre;
    #domicilio;
    #residencia;
    #numRegIdTrib;
    #regimenFiscal;
    #usoCFDI;

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
        this.#domicilio = this.#lorem.generateWords(this.#GetRandomInt(10, 30));
    }

    async Populate() {
        if (Math.random() < 0.5) {
            let [residencia] = await DatabaseHandler.Query("SELECT id FROM c_pais ORDER BY RAND() LIMIT 1");

            if (residencia !== "MEX") {
                this.#residencia = residencia.id;
                this.#numRegIdTrib = this.#MakeID(16, 2)
            }
        }

        let [regimenFiscal] = await DatabaseHandler.Query("SELECT id FROM c_regimen_fiscal ORDER BY RAND() LIMIT 1");
        this.#regimenFiscal = regimenFiscal.id;

        let [usoCFDI] = await DatabaseHandler.Query("SELECT id FROM c_uso_cfdi ORDER BY RAND() LIMIT 1");
        this.#usoCFDI = usoCFDI.id;
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
        let databaseID = await DatabaseHandler.Query("INSERT INTO receptores SET ?", [
            {
                rfc: this.#rfc,
                nombre: this.#nombre,
                domicilio: this.#domicilio,
                residencia: this.#residencia,
                num_reg_id_trib: this.#numRegIdTrib,
                regimen_fiscal: this.#regimenFiscal,
                uso_cfdi: this.#usoCFDI
            }
        ]);

        this.#dbId = databaseID.insertId;
    }

    GetDatabaseId() {
        return this.#dbId;
    }
}

export { Receptor };
