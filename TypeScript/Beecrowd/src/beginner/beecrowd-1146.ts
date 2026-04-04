import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);

for (const element of input) {
	if (element === 0) {
		break;
	}

	let word = "";

	for (let index = 1; index <= element; index++) {
		if (index !== element) {
			word += `${index} `;
		} else {
			word += `${index}`;
		}
	}
	console.log(word);
}
