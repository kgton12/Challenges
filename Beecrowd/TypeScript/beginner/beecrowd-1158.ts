import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);

// const input = ["2", "4 5", "7 4"];

const i = Number.parseInt(input.shift() ?? "0");
let numArray: number[] = [];

for (let index = 0; index < i; index++) {
	let [X, Y] = input[index].split(" ").map(Number);

	// if ([X, Y].includes(0)) break;

	while (numArray.length !== Y) {
		if (X % 2 !== 0) {
			numArray.push(X);
		}
		X++;
	}
	console.log(
		numArray.reduce((prev, curr) => {
			return prev + curr;
		}),
	);
	numArray = [];
}
