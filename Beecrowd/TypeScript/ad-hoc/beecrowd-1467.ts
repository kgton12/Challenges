import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const input = ["1 1 0", "0 0 0", "1 0 0"];

// const input = require("node:fs").readFileSync("/dev/stdin", "utf8");
// const lines = input.split("\n");

processInput(input);

function processInput(input: string[]) {
	const lines = input;

	for (const line of lines) {
		if (!line.trim()) break;
		const [A, B, C] = line.split(" ");
		console.log(determineWinner(A, B, C));
	}
}

function determineWinner(A: string, B: string, C: string) {
	if (A !== B && A !== C) {
		return "A";
	}

	if (B !== A && B !== C) {
		return "B";
	}

	if (C !== A && C !== B) {
		return "C";
	}

	return "*";
}
