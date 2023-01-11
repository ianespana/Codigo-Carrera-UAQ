const mg = require('mongodb').MongoClient;
const url = 'mongodb://localhost:27017/mydb';
mg.connect(url, { useUnifiedTopology: true }, function (err, db) {
    if (err) throw err;
    const dbo = db.db('mydb');
    const query = {edad: '10'};
    const sort = { edad: 1 };
    dbo.collection('customers').find(query).sort(sort).toArray(function (err, result) {
        if (err) throw err;
        console.log('1. ------------------------------------------');
        console.log(result);
        db.close();
    });
});