import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

let i = 0;

while (i <= 2) {
	console.log(`I=${rounds(i)} J=${rounds(i + 1)}`);
	console.log(`I=${rounds(i)} J=${rounds(i + 2)}`);
	console.log(`I=${rounds(i)} J=${rounds(i + 3)}`);
	i += 0.2;
}

function rounds(n: number): string {
	const rounded = Math.round(n * 10) / 10;
	return rounded % 1 === 0 ? rounded.toString() : rounded.toFixed(1);
}
