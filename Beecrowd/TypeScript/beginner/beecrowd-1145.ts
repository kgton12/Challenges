import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(" ").map(Number);

const length = input[0];
const values = input[1];
let j = 0;

for (let index = 1; index <= values; index += length) {
	let word = "";

	for (let i = 1; i <= length; i++) {
		j++;
		if (i === length) {
			word += `${j}`;
		} else {
			word += `${j} `;
		}
	}
	console.log(word);
}
