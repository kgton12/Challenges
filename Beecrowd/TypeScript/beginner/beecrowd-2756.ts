import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

// const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
function printPattern() {
	const lines = [
		{ spaces: 7, char: "A" },
		{ spaces: 6, char: "B", extraSpaces: 1 },
		{ spaces: 5, char: "C", extraSpaces: 3 },
		{ spaces: 4, char: "D", extraSpaces: 5 },
		{ spaces: 3, char: "E", extraSpaces: 7 },
		{ spaces: 4, char: "D", extraSpaces: 5 },
		{ spaces: 5, char: "C", extraSpaces: 3 },
		{ spaces: 6, char: "B", extraSpaces: 1 },
		{ spaces: 7, char: "A" },
	];

	for (const line of lines) {
		let output = " ".repeat(line.spaces) + line.char;
		if (line.extraSpaces !== undefined) {
			output += " ".repeat(line.extraSpaces) + line.char;
		}
		console.log(output);
	}
}

printPattern();
