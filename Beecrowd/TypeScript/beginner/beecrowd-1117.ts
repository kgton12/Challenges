import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
// const input = [-3.5,
//     3.5,
//     11.0,
//     10.0];

let sum = 0;
let count = 0;

for (const element of input) {
	if (element < 0 || element > 10) {
		console.log("nota invalida");
	} else {
		sum += element;
		count++;
	}

	if (count === 2) {
		console.log(`media = ${(sum / 2).toFixed(2)}`);
	}
}
