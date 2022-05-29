import {DatabaseHandler} from "../handlers/DatabaseHandler.js";

class Complemento {
    #dbId;

    async SaveToDatabase() {
        let databaseID = await DatabaseHandler.Query("INSERT INTO complementos SET ?", [
            {
                id: null
            }
        ]);

        this.#dbId = databaseID.insertId;
    }

    GetDatabaseId() {
        return this.#dbId;
    }
}

export { Complemento };
