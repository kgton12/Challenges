import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
// const input = [3,2];

const menu = [
	{
		id: 1,
		price: 4.0,
	},
	{
		id: 2,
		price: 4.5,
	},
	{
		id: 3,
		price: 5.0,
	},
	{
		id: 4,
		price: 2.0,
	},
	{
		id: 5,
		price: 1.5,
	},
];

console.log(`Total: R$ ${(menu[input[0] - 1].price * input[1]).toFixed(2)}`);
