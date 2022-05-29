import {DatabaseHandler} from "../handlers/DatabaseHandler.js";

class Retencion {
    #base;
    #tipoImpuesto;
    #tipoFactor;
    #tasaCuota;
    #importe;
    #dbId;

    /** Creates a new object of type Retencion
     */
    constructor() {
        this.#base = this.#GetRandomArbitrary(0.1, 0.16);
    }

    async Populate() {
        let [tipoImpuesto] = await DatabaseHandler.Query("SELECT id FROM c_impuesto ORDER BY RAND() LIMIT 1");
        this.#tipoImpuesto = tipoImpuesto.id;

        let [tipoFactor] = await DatabaseHandler.Query("SELECT id FROM c_tipo_factor ORDER BY RAND() LIMIT 1");
        this.#tipoFactor = tipoFactor.id;

        let [tasaCuota] = await DatabaseHandler.Query("SELECT id FROM c_tasa_cuota ORDER BY RAND() LIMIT 1");
        this.#tasaCuota = tasaCuota.id;
    }

    #RoundToTwo(num) {
        return +(Math.round(num + "e+2")  + "e-2");
    }

    #GetRandomArbitrary(min = 0, max = 1) {
        return this.#RoundToTwo(Math.random() * (max - min) + min);
    }

    async SaveToDatabase() {
        let databaseID = await DatabaseHandler.Query("INSERT INTO retenciones SET ?", [
            {
                base: this.#base,
                impuesto: this.#tipoImpuesto,
                tipo_factor: this.#tipoFactor,
                tasa_cuota: this.#tasaCuota,
                importe: this.#importe
            }
        ]);

        this.#dbId = databaseID.insertId;
    }

    GetBase() {
        return this.#importe;
    }

    CalculateImporte(total) {
        this.#importe = total * this.#base;
    }

    GetImporte() {
        return this.#importe;
    }

    GetDatabaseId() {
        return this.#dbId;
    }
}

export { Retencion };
