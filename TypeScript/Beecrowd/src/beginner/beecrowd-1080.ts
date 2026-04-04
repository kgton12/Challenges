import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
// const input = ['3',
// 	'6.5 4.3 6.2',
// 	'5.1 4.2 8.1',
// 	'8.0 9.0 10.0'];

// const i = Number.parseInt(input[0]);

let biggerNumber = 0;
let i = 0;

for (let index = 0; index < input.length; index++) {
	if (input[index] > biggerNumber) {
		biggerNumber = input[index];
		i = index;
	}
}
console.log(biggerNumber);
console.log(i + 1);
