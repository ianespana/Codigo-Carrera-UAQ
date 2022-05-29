import {DatabaseHandler} from "../handlers/DatabaseHandler.js";
import {Impuesto} from "./Impuesto.js";
import {LoremIpsum} from "lorem-ipsum";
import {CuentaTerceros} from "./CuentaTerceros.js";
import {CuentaPredial} from "./CuentaPredial.js";
import {Complemento} from "./Complemento.js";

class Concepto {
    #claveProdServ;
    #numIdentificacion;
    #cantidad;
    #claveUnidad;
    #descripcion;
    #valorUnitario;
    #importe;
    #descuento;
    #objetoImp;
    #idImpuesto;
    #idCuentaTerceros;
    #idCuentaPredial;
    #idComplemento;

    #impuesto;
    #cuentaTerceros;
    #cuentaPredial;
    #complemento;
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

    /** Creates a new object of type Concepto
     */
    constructor() {
        if (Math.random() < 0.5) {
            this.#numIdentificacion = this.#GetRandomInt(1, 1000000);
        }

        this.#cantidad = this.#GetRandomInt(1, 100);
        this.#descripcion = this.#lorem.generateWords(this.#GetRandomInt(10, 50));
        this.#valorUnitario = this.#RoundToTwo(this.#GetRandomArbitrary(0.01, 10000));
        this.#importe = this.#RoundToTwo(this.#cantidad * this.#valorUnitario);

        if (Math.random() < 0.5) {
            this.#descuento = this.#RoundToTwo(this.#GetRandomArbitrary(0, this.#importe));
        }
    }

    async Populate() {
        let [claveProdServ] = await DatabaseHandler.Query("SELECT id FROM c_clave_prod_serv ORDER BY RAND() LIMIT 1");
        this.#claveProdServ = claveProdServ.id;

        let [claveUnidad] = await DatabaseHandler.Query("SELECT id FROM c_clave_unidad ORDER BY RAND() LIMIT 1");
        this.#claveUnidad = claveUnidad.id;

        let [objetoImp] = await DatabaseHandler.Query("SELECT id FROM c_objeto_imp ORDER BY RAND() LIMIT 1");
        this.#objetoImp = objetoImp.id;

        if (Math.random() < 0.5) {
            this.#impuesto = new Impuesto();
            await this.#impuesto.Populate();
            this.#impuesto.CalculateImporte(this.#importe);
        }

        if (Math.random() < 0.5) {
            this.#cuentaTerceros = new CuentaTerceros();
            await this.#cuentaTerceros.Populate();
        }

        if (Math.random() < 0.5) {
            this.#cuentaPredial = new CuentaPredial();
        }

        if (Math.random() < 0.5) {
            this.#complemento = new Complemento();
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
        if (this.#impuesto) {
            await this.#impuesto.SaveToDatabase();
            this.#idImpuesto = this.#impuesto.GetDatabaseId();
        }

        if (this.#cuentaTerceros) {
            await this.#cuentaTerceros.SaveToDatabase();
            this.#idCuentaTerceros = this.#cuentaTerceros.GetDatabaseId();
        }

        if (this.#cuentaPredial) {
            await this.#cuentaPredial.SaveToDatabase();
            this.#idCuentaPredial = this.#cuentaPredial.GetDatabaseId();
        }

        if (this.#complemento) {
            await this.#complemento.SaveToDatabase();
            this.#idComplemento = this.#complemento.GetDatabaseId();
        }

        let databaseID = await DatabaseHandler.Query("INSERT INTO conceptos SET ?", [
            {
                clave_prod_serv: this.#claveProdServ,
                num_identificacion: this.#numIdentificacion,
                cantidad: this.#cantidad,
                clave_unidad: this.#claveUnidad,
                descripcion: this.#descripcion,
                valor_unitario: this.#valorUnitario,
                importe: this.#importe,
                descuento: this.#descuento,
                objeto_imp: this.#objetoImp,
                id_impuesto: this.#idImpuesto,
                id_cuenta_terceros: this.#idCuentaTerceros,
                id_cuenta_predial: this.#idCuentaPredial,
                id_complementos: this.#idComplemento
            }
        ]);

        this.#dbId = databaseID.insertId;
    }

    GetImporte() {
        return this.#importe;
    }

    GetDescuento() {
        if (!this.#descuento) return 0;
        return this.#descuento;
    }

    GetImpuesto() {
        return this.#impuesto;
    }

    GetDatabaseId() {
        return this.#dbId;
    }
}

export { Concepto };