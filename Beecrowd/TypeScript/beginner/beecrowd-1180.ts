import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const input = ["10", "1 2 3 4 -5 6 7 8 9 10"];
const arrayLength = Number.parseInt(input.shift() ?? "0");
const array = input[0].split(" ").map(Number);
let smaller = Number.MAX_SAFE_INTEGER;
let i = 0;

for (let index = 0; index < arrayLength; index++) {
	if (array[index] < smaller) {
		smaller = array[index];
		i = index;
	}
}
console.log(`Menor valor: ${smaller}`);
console.log(`Posicao: ${i}`);
