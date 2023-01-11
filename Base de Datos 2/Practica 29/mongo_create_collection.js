const mg = require('mongodb').MongoClient;
const url = 'mongodb://localhost:27017/mydb';
mg.connect(url, { useUnifiedTopology: true }, function (err, db) {
    if (err) throw err;
    var dbo = db.db('mydb');
    dbo.createCollection('customers', function (err, res) {
        if (err) throw err;
        console.log('Colección creada!');
        db.close();
    });
});