import {DatabaseHandler} from "../handlers/DatabaseHandler.js";

class CuentaPredial {
    #numero;
    #dbId;

    /** Creates a new object of type CuentaPredial
     */
    constructor() {
        this.#numero = this.#GetRandomInt(1, 2147483646);
    }

    #GetRandomInt(min = 0, max = 1) {
        return Math.floor(Math.random() * (max - min)) + min;
    }

    async SaveToDatabase() {
        let databaseID = await DatabaseHandler.Query("INSERT INTO cuentas_predial SET ?", [
            {
                numero: this.#numero
            }
        ]);

        this.#dbId = databaseID.insertId;
    }

    GetDatabaseId() {
        return this.#dbId;
    }
}

export { CuentaPredial };
