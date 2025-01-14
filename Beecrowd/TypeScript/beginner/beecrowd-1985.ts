import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);

const product = [
	{
		code: 1001,
		value: 1.5,
	},
	{
		code: 1002,
		value: 2.5,
	},
	{
		code: 1003,
		value: 3.5,
	},
	{
		code: 1004,
		value: 4.5,
	},
	{
		code: 1005,
		value: 5.5,
	},
];
// const input = ["1", "1003 500"];

const productsQuantity = Number.parseInt(input.shift() ?? "0");

let sum = 0;

for (let index = 0; index < productsQuantity; index++) {
	const [id, quantity] = input[index].split(" ").map(Number);

	sum += (product.find((item) => item.code === id)?.value ?? 0) * quantity;
}

console.log(sum.toFixed(2));
