import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
// const input = [111];

const DDD = [
	{
		ddd: 61,
		name: "Brasilia",
	},
	{
		ddd: 71,
		name: "Salvador",
	},
	{
		ddd: 11,
		name: "Sao Paulo",
	},
	{
		ddd: 21,
		name: "Rio de Janeiro",
	},
	{
		ddd: 32,
		name: "Juiz de Fora",
	},
	{
		ddd: 19,
		name: "Campinas",
	},
	{
		ddd: 27,
		name: "Vitoria",
	},
	{
		ddd: 31,
		name: "Belo Horizonte",
	},
];

const ddd = DDD.find((value) => value.ddd === input[0]);
console.log(ddd ? ddd.name : "DDD nao cadastrado");
