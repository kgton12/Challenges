import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(" ").map(Number);
// const input = [7, 21, -14];

console.log(
	input
		.slice()
		.sort((a, b) => a - b)
		.join(EOL),
);
console.log("");
console.log(input.join(EOL));
