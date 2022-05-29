import {DatabaseHandler} from "../handlers/DatabaseHandler.js";
import {Impuesto} from "./Impuesto.js";
import {LoremIpsum} from "lorem-ipsum";
import {Complemento} from "./Complemento.js";
import {Concepto} from "./Concepto.js";
import {InformacionGlobal} from "./InformacionGlobal.js";
import {Emisor} from "./Emisor.js";
import {Receptor} from "./Receptor.js";

class Comprobante {
    #version = "4.0";
    #serie;
    #folio;
    #fecha;
    #sello;
    #formaPago;
    #numCertificado;
    #certificado;
    #condicionesPago;
    #subtotal = 0;
    #descuento = 0;
    #moneda;
    #tipoCambio;
    #total;
    #tipoComprobante;
    #metodoPago;
    #lugarExpedicion;
    #confirmacion;
    #estatus;

    #idInformacionGlobal;
    #idImpuesto;

    #informacionGlobal;
    #emisor;
    #receptor;
    #impuesto;
    #complemento;

    #conceptos = [];

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

    /** Creates a new object of type Comprobante
     */
    constructor() {
        if (Math.random() < 0.5) {
            this.#serie = this.#MakeID(16, 1);
        }

        if (Math.random() < 0.5) {
            this.#folio = this.#MakeID(16, 2);
        }

        this.#fecha = this.#GetRandomDate(new Date(2010, 1, 1), new Date());

        let buff = new Buffer(this.#lorem.generateSentences(this.#GetRandomInt(1, 10)));
        this.#sello = buff.toString("base64");

        this.#numCertificado = this.#MakeID(20, 2);

        buff = new Buffer(this.#lorem.generateSentences(this.#GetRandomInt(1, 10)));
        this.#certificado = buff.toString("base64");

        this.#condicionesPago = this.#lorem.generateWords(this.#GetRandomInt(3, 30));

        if (Math.random() < 0.5) {
            this.#confirmacion = this.#MakeID(20, 1);
        }

        this.#estatus = this.#MakeID(6, 3);
    }

    async Populate() {
        for (let i = 0; i < this.#GetRandomInt(1, 10); i++) {
            let concepto = new Concepto();
            await concepto.Populate();
            this.#conceptos.push(concepto);
        }

        for (const concepto of this.#conceptos) {
            this.#subtotal += concepto.GetImporte();
            this.#descuento += concepto.GetDescuento();
        }

        this.#subtotal = this.#RoundToTwo(this.#subtotal);
        this.#descuento = this.#RoundToTwo(this.#descuento);

        if (this.#descuento === 0) {
            this.#descuento = null;
        }

        if (Math.random() < 0.5) {
            let [formaPago] = await DatabaseHandler.Query("SELECT id FROM c_forma_pago ORDER BY RAND() LIMIT 1");
            this.#formaPago = formaPago.id;
        }

        let [moneda] = await DatabaseHandler.Query("SELECT id FROM c_moneda ORDER BY RAND() LIMIT 1");
        this.#moneda = moneda.id;

        if (this.#moneda !== "MXN" || this.#moneda !== "XXX") {
            this.#tipoCambio = this.#GetRandomArbitrary(0.0001, 22);
        }

        let [tipoComprobante] = await DatabaseHandler.Query("SELECT id FROM c_tipo_comprobante ORDER BY RAND() LIMIT 1");
        this.#tipoComprobante = tipoComprobante.id;

        if (Math.random() < 0.5) {
            let [metodoPago] = await DatabaseHandler.Query("SELECT id FROM c_metodo_pago ORDER BY RAND() LIMIT 1");
            this.#metodoPago = metodoPago.id;
        }

        let [lugarExpedicion] = await DatabaseHandler.Query("SELECT id FROM c_codigo_postal ORDER BY RAND() LIMIT 1");
        this.#lugarExpedicion = lugarExpedicion.id;

        if (Math.random() < 0.5) {
            this.#informacionGlobal = new InformacionGlobal(this.#fecha.getFullYear());
            await this.#informacionGlobal.Populate();
        }

        this.#emisor = new Emisor();
        await this.#emisor.Populate();

        this.#receptor = new Receptor();
        await this.#receptor.Populate();

        if (Math.random() < 0.5) {
            this.#impuesto = new Impuesto();
            await this.#impuesto.Populate();
        }

        this.#complemento = new Complemento();

        // TODO: Calcular total
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

    #RoundToTwo(num) {
        return +(Math.round(num + "e+2")  + "e-2");
    }

    #GetRandomArbitrary(min = 0, max = 1) {
        return Math.random() * (max - min) + min;
    }

    #GetRandomInt(min = 0, max = 1) {
        return Math.floor(Math.random() * (max - min)) + min;
    }

    #GetRandomDate(start, end) {
        return new Date(start.getTime() + Math.random() * (end.getTime() - start.getTime()));
    }

    async SaveToDatabase() {
        for (const concepto of this.#conceptos) {
            await concepto.SaveToDatabase();
        }

        if (this.#informacionGlobal) {
            await this.#informacionGlobal.SaveToDatabase();
            this.#idInformacionGlobal = this.#informacionGlobal.GetDatabaseId();
        }

        await this.#emisor.SaveToDatabase();
        await this.#receptor.SaveToDatabase();

        if (this.#impuesto) {
            this.#impuesto.CalculateImporte(this.#subtotal)
            await this.#impuesto.SaveToDatabase();
            this.#idImpuesto = this.#impuesto.GetDatabaseId();
        }

        await this.#complemento.SaveToDatabase();

        let databaseID = await DatabaseHandler.Query("INSERT INTO comprobantes SET ?", [
            {
                version: this.#version,
                serie: this.#serie,
                folio: this.#folio,
                fecha: this.#fecha.YYYYMMDDHHMMSS(),
                sello: this.#sello,
                forma_pago: this.#formaPago,
                num_certificado: this.#numCertificado,
                certificado: this.#certificado,
                condiciones_pago: this.#condicionesPago,
                subtotal: this.#subtotal,
                descuento: this.#descuento,
                moneda: this.#moneda,
                tipo_cambio: this.#tipoCambio,
                total: this.#total,
                tipo_comprobante: this.#tipoComprobante,
                metodo_pago: this.#metodoPago,
                lugar_expedicion: this.#lugarExpedicion,
                confirmacion: this.#confirmacion,
                estatus: this.#estatus,
                id_informacion_global: this.#idInformacionGlobal,
                id_emisor: this.#emisor.GetDatabaseId(),
                id_receptor: this.#receptor.GetDatabaseId(),
                id_impuestos: this.#idImpuesto,
                id_complemento: this.#complemento.GetDatabaseId()
            }
        ]);

        this.#dbId = databaseID.insertId;

        for (const concepto of this.#conceptos) {
            await DatabaseHandler.Query("INSERT INTO comprobantes_conceptos SET ?", [
                {
                    id_comprobante: this.GetDatabaseId(),
                    id_concepto: concepto.GetDatabaseId()
                }
            ]);
        }
    }

    GetDatabaseId() {
        return this.#dbId;
    }
}

export { Comprobante };