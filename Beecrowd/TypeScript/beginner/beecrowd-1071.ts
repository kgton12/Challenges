import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL, 2).map(Number);
// const input = [6, -5];
const [final, initial] = input;
let sumOdd = 0;

for (let i = initial + 1; i < final; i++) {
	if (i % 2 !== 0) {
		sumOdd += i;
	}
}

console.log(sumOdd);
