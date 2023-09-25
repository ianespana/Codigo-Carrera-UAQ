const morgan = require('morgan');
const express = require('express');
const app = express();
const pokemonRouter = require('./routes/pokemon')

app.use(morgan('dev'));
app.use(express.json());
app.use(express.urlencoded({ extended: true }));

app.get('/', (req, res) => {
    return res.status(200).send('Bienvenido al pokedex');
});

app.use('/pokemon', pokemonRouter);

app.listen(process.env.PORT || 3000, () => {
    console.log(`Server is running on port ${process.env.PORT || 3000}`);
});