import {DatabaseHandler} from "../handlers/DatabaseHandler.js";
import {Retencion} from "./Retencion.js";
import {Traslado} from "./Traslado.js";

class Impuesto {
    #retenciones = [];
    #traslados = [];
    #totalRetenciones = 0;
    #totalTraslados = 0;
    #dbId;

    async Populate() {
        for (let i = 0; i < this.#GetRandomInt(0, 10); i++) {
            let retencion = new Retencion();
            await retencion.Populate();
            this.#retenciones.push(retencion);
        }

        for (let i = 0; i < this.#GetRandomInt(0, 10); i++) {
            let traslado = new Traslado();
            await traslado.Populate();
            this.#traslados.push(traslado);
        }
    }

    #RoundToTwo(num) {
        return +(Math.round(num + "e+2")  + "e-2");
    }

    #GetRandomArbitrary(min = 0, max = 1) {
        return Math.random() * (max - min) + min;
    }

    #GetRandomInt(min = 0, max = 1) {
        return Math.floor(Math.random() * (max - min)) + min;
    }

    async SaveToDatabase() {
        for (const retencion of this.#retenciones) {
            await retencion.SaveToDatabase();
        }

        for (const traslado of this.#traslados) {
            await traslado.SaveToDatabase();
        }

        let databaseID = await DatabaseHandler.Query("INSERT INTO impuestos SET ?", [
            {
                total_impuestos_retenidos: this.#totalRetenciones,
                total_impuestos_trasladados: this.#totalTraslados
            }
        ]);

        this.#dbId = databaseID.insertId;

        for (const retencion of this.#retenciones) {
            await DatabaseHandler.Query("INSERT INTO impuestos_retenciones SET ?", [
                {
                    id_impuestos: this.GetDatabaseId(),
                    id_retenciones: retencion.GetDatabaseId()
                }
            ]);
        }

        for (const traslado of this.#traslados) {
            await DatabaseHandler.Query("INSERT INTO impuestos_traslados SET ?", [
                {
                    id_impuestos: this.GetDatabaseId(),
                    id_traslados: traslado.GetDatabaseId()
                }
            ]);
        }
    }

    CalculateImporte(total) {
        for (const retencion of this.#retenciones) {
            retencion.CalculateImporte(total);
            this.#totalRetenciones += retencion.GetImporte();
        }

        for (const traslado of this.#traslados) {
            if (Math.random() < 0.5) {
                traslado.CalculateImporte(total);
                this.#totalTraslados += traslado.GetImporte();
            }
        }

        this.#totalRetenciones = this.#RoundToTwo(this.#totalRetenciones);
        this.#totalTraslados = this.#RoundToTwo(this.#totalTraslados);

        if (this.#totalRetenciones === 0) {
            this.#totalRetenciones = null;
        }

        if (this.#totalTraslados === 0) {
            this.#totalTraslados = null;
        }
    }

    GetTotalRetenciones() {
        return this.#totalRetenciones;
    }

    GetTotalTraslados() {
        return this.#totalTraslados;
    }

    GetDatabaseId() {
        return this.#dbId;
    }
}

export { Impuesto };
