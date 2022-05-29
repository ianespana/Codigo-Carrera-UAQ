import {DatabaseHandler} from "../handlers/DatabaseHandler.js";

class InformacionGlobal {
    #periodicidad;
    #meses;
    #year;

    #dbId;

    /** Creates a new object of type InformacionGlobal
     */
    constructor(year) {
        this.#year = year;
    }

    async Populate() {
        let [periodicidad] = await DatabaseHandler.Query("SELECT id FROM c_periodicidad ORDER BY RAND() LIMIT 1");
        this.#periodicidad = periodicidad.id;

        let [meses] = await DatabaseHandler.Query("SELECT id FROM c_meses ORDER BY RAND() LIMIT 1");
        this.#meses = meses.id;
    }

    async SaveToDatabase() {
        let databaseID = await DatabaseHandler.Query("INSERT INTO informacion_global SET ?", [
            {
                periodicidad: this.#periodicidad,
                meses: this.#meses,
                año: this.#year
            }
        ]);

        this.#dbId = databaseID.insertId;
    }

    GetDatabaseId() {
        return this.#dbId;
    }
}

export { InformacionGlobal };
