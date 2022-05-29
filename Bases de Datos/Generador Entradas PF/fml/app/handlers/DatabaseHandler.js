import mysql from "mysql2";
import "dotenv/config";

class DatabaseHandler {
    static #dbConnectionLimit = parseInt(process.env.DB_CONNECTION_LIMIT);

    static #satPool = mysql.createPool({
        host: process.env.DB_HOST,
        user: process.env.DB_USER,
        password: process.env.DB_PASSWORD,
        database: process.env.DB_NAME,
        connectionLimit: this.#dbConnectionLimit,
    });

    static #satPromisePool = this.#satPool.promise();

    /** Creates and executes the given query on the database
     * @param {string} query The query to execute
     * @param {Object} opts The query options to add to the query
     * @returns {Object} The result of the query. If no result was found returns null
     */
    static async Query(query, opts = []) {
        let [response] = await this.#satPromisePool.query(query, opts);
        return response;
    }

    /** Formats and sanitizes the given query string
     * @param {string} query The query to format
     * @param {any[]} opts The query options to add to the query
     * @returns {string} The formatted query
     */
    static Format(query, opts) {
        return mysql.format(query, opts);
    }
}

export { DatabaseHandler };
