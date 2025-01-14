import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);

// const input = [4, 11, 0];
let numArray: number[] = [];

for (const element of input) {
	if (element === 0) break;

	let i = element;
	while (numArray.length !== 5) {
		if (i % 2 === 0) {
			numArray.push(i);
		}
		i++;
	}
	console.log(
		numArray.reduce((prev, curr) => {
			return prev + curr;
		}),
	);
	numArray = [];
}
