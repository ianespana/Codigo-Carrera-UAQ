const mg = require('mongodb').MongoClient;
const url = 'mongodb://localhost:27017/';
mg.connect(url, { useUnifiedTopology: true }, function (err, db) {
    if (err) throw err;
    const dbo = db.db('mydb');
    const doc = { name: 'Tu nombre', edad: 'Tu edad' };
    dbo.collection('customers').insertOne(doc, function (err, res) {
        if (err) throw err;
        console.log('1 documento insertado');
        db.close();
    });
});