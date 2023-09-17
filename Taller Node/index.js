const express = require('express');
const app = express();
const { pokemon } = require('./pokedex.json');

app.use(express.json());
app.use(express.urlencoded({ extended: true }));

app.get('/', (req, res) => {
    return res.status(200).send('Bienvenido al pokedex');
});

app.post('/pokemon', (req, res) => {
    return res.status(200).send(req.body);
});

app.get('/pokemon', (req, res) => {
    return res.status(200).send(pokemon);
});

app.get('/pokemon/:id([0-9]{1-3})', (req, res) => {
    if (req.params.id > 151) {
        return res.status(404).send('No se encontró el pokemon');
    }

    return res.status(200).send(pokemon[req.params.id - 1]);
});

app.get('/pokemon/:name([a-zA-Z]+)', (req, res) => {
    const name = req.params.name.toLowerCase();
    const pk = pokemon.find((p) => p.name.toLowerCase() === name);

    if (!pk) {
        return res.status(404).send('No se encontró el pokemon');
    }

    return res.status(200).send(pk);
});

app.listen(process.env.PORT || 3000, () => {
    console.log(`Server is running on port ${process.env.PORT || 3000}`);
});