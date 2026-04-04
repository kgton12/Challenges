import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);

console.log(calculateFactorial(input[0]));

function calculateFactorial(N: number): number {
	if (N === 0 || N === 1) {
		return 1;
	}
	let factorial = 1;
	for (let i = N; i > 1; i--) {
		factorial *= i;
	}

	return factorial;
}
