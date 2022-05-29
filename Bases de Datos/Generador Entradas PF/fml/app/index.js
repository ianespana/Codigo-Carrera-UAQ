import {Comprobante} from "./classes/Comprobante.js";

Object.defineProperty(Date.prototype, "YYYYMMDDHHMMSS", {
    value: function () {
        function pad2(n) {
            // always returns a string
            return (n < 10 ? "0" : "") + n;
        }

        return (
            this.getFullYear() +
            pad2(this.getMonth() + 1) +
            pad2(this.getDate()) +
            pad2(this.getHours()) +
            pad2(this.getMinutes()) +
            pad2(this.getSeconds())
        );
    },
});

Object.defineProperty(Date.prototype, "YYYYMMDD", {
    value: function () {
        function pad2(n) {
            // always returns a string
            return (n < 10 ? "0" : "") + n;
        }

        return (
            this.getFullYear() +
            pad2(this.getMonth() + 1) +
            pad2(this.getDate())
        );
    },
});

async function main() {
    for (let i = 0; i < 1000; i++) {
        let comprobante = new Comprobante();
        await comprobante.Populate();
        await comprobante.SaveToDatabase();
    }

    process.exit(1);
}

main();
