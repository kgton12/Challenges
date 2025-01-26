import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);

// const input = ["5", "0 0 1 0 1", "6", "0 0 0 0 0 1", "0"];

let mary = 0;
let john = 0;

for (let index = 0; index < input.length; index += 2) {
	if (input[index] === "0") break;

	const headsOrTails = input[index + 1].split(" ").map(Number);

	for (const element of headsOrTails) {
		if (element === 0) {
			mary++;
		} else {
			john++;
		}
	}
	console.log(`Mary won ${mary} times and John won ${john} times`);

	mary = 0;
	john = 0;
}
