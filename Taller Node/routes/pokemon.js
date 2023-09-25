const express = require('express');
const pokemonRouter = express.Router();
const { pokemones } = require('../pokedex.json');

pokemonRouter.post('/', (req, res) => {
	return res.status(200).send(req.body);
});

pokemonRouter.get('/', (req, res) => {
	return res.status(200).send(pokemones);
});

pokemonRouter.get('/:id([0-9]{1-3})', (req, res) => {
	if (req.params.id > 151) {
		return res.status(404).send('No se encontró el pokemon');
	}

	return res.status(200).send(pokemones[req.params.id - 1]);
});

pokemonRouter.get('/:name([a-zA-Z]+)', (req, res) => {
	const name = req.params.name.toLowerCase();
	const pokemon = pokemones.find((p) => p.name.toLowerCase() === name);

	if (!pokemon) {
		return res.status(404).send('No se encontró el pokemon');
	}

	return res.status(200).send(pokemon);
});

module.exports = pokemonRouter;