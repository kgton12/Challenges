import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = Number.parseInt(readFileSync(stdin.fd, { encoding: "utf8" }));

// const input = 8;
let wordHo = "";

for (let index = 0; index < input; index++) {
	if (index === input - 1) {
		wordHo += "Ho!";
		break;
	}
	wordHo += "Ho ";
}
console.log(wordHo);
