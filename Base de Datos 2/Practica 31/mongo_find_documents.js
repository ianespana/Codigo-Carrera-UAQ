const mg = require('mongodb').MongoClient;
const url = 'mongodb://localhost:27017/mydb';
mg.connect(url, { useUnifiedTopology: true }, function (err, db) {
    if (err) throw err;
    const dbo = db.db('mydb');
    dbo.collection('customers').findOne({}, function (err, result) {
        if (err) throw err;
        console.log('1. ------------------------------------------');
        console.log(result);
        db.close();
    });
});

mg.connect(url, { useUnifiedTopology: true }, function (err, db) {
    if (err) throw err;
    const dbo = db.db('mydb');
    dbo.collection('customers').find({}).toArray(function (err, result) {
        if (err) throw err;
        console.log('2. ------------------------------------------');
        console.log(result);
        db.close();
    });
});