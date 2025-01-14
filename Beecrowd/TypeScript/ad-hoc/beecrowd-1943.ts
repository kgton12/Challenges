import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

// const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
const input = 26;
const ranks = [1, 3, 5, 10, 25, 50, 100];

for (const rank of ranks) {
	if (input <= rank) {
		console.log(`Top ${rank}`);
		break;
	}
}
