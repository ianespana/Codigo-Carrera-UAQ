const mg = require('mongodb').MongoClient;
const url = "mongodb://localhost:27017/mydb";
mg.connect(url, { useUnifiedTopology: true }, function (err, db) {
    if (err) throw err;
    console.log("Database created!");
    db.close();
});