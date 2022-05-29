import mysql from "mysql2";
import pg from 'pg';
import "dotenv/config";
const { Pool } = pg

class DatabaseHandler {
    static #dbConnectionLimit = parseInt(process.env.DB_CONNECTION_LIMIT);
    static #satPool;
    static #satPromisePool;

    static Initialize() {
        if(process.env.MYSQL === "true"){
            this.#satPool = mysql.createPool({
                host: process.env.DB_HOST,
                user: process.env.DB_USER,
                password: process.env.DB_PASSWORD,
                database: process.env.DB_NAME,
                connectionLimit: this.#dbConnectionLimit,
            });

            this.#satPromisePool = this.#satPool.promise();
        } else {
            this.#satPool = new Pool({
                host: process.env.DB_HOST,
                user: process.env.DB_USER,
                password: process.env.DB_PASSWORD,
                database: process.env.DB_NAME,
                max: this.#dbConnectionLimit,
            });

            this.#satPromisePool = this.#satPool;
        }
    }

    /** Creates and executes the given query on the database
     * @param {string} query The query to execute
     * @param {Object} opts The query options to add to the query
     * @returns {Object} The result of the query. If no result was found returns null
     */
    static async Query(query, opts = []) {
        if(process.env.MYSQL !== "true") {
            query = query.replace("RAND()", "RANDOM()")
        }

        try {
            if(process.env.MYSQL !== "true") {
                let response = await this.#satPromisePool.query(query, opts);
                response = response.rows
                return response;
            } else {
                let [response] = await this.#satPromisePool.query(query, opts);
                return response;
            }
        } catch (e) {
            console.log(query);
            console.log(e);
        }
    }

    /** Formats and sanitizes the given query string
     * @param {string} query The query to format
     * @param {any[]} opts The query options to add to the query
     * @returns {string} The formatted query
     */
    static Format(query, opts) {
        return mysql.format(query, opts);
    }

    static Terminate() {
        if(process.env.MYSQL === "true"){
            return;
        } else {
            this.#satPool.end();
        }
    }
}

export { DatabaseHandler };
