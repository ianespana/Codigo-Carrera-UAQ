const express = require('express');
const app = express();
const pokedex = require('./pokedex.json');

app.get('/', (req, res) => {
    res.status(200).send('Bienvenido al servidor');
});

app.get('/pokemon/all', (req, res) => {
    res.status(200).send(pokedex);
});

app.get('/pokemon/:id([0-9]{1-3})', (req, res) => {
    if (req.params.id > 151) {
        res.status(404).send('No se encontró el pokemon');
        return;
    }

    res.status(200).send(pokedex[req.params.id - 1]);
});

app.get('/pokemon/:name', (req, res) => {
    const name = req.params.name.toLowerCase();
    const pokemon = pokedex.find((p) => p.name.toLowerCase() === name);

    if (!pokemon) {
        res.status(404).send('No se encontró el pokemon');
        return;
    }

    res.status(200).send(pokemon);
});

app.listen(process.env.PORT || 3000, () => {
    console.log(`Server is running on port ${process.env.PORT || 3000}`);
});