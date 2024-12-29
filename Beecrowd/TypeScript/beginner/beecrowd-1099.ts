import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const input = ["7",
//     "4 5",
//     "13 10",
//     "6 4",
//     "3 3",
//     "3 5",
//     "3 4",
//     "3 8"]

const i = Number.parseInt(input[0]);

for (let index = 1; index <= i; index++) {
	const [initialNumber, finalNumber] = input[index]
		.split(" ")
		.map(Number)
		.sort((a, b) => a - b);

	let sum = 0;

	for (let i = initialNumber + 1; i < finalNumber; i++) {
		if (i % 2 !== 0) {
			sum += i;
		}
	}
	console.log(sum);
}