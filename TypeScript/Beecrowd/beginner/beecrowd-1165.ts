import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
// const input = [3, 8, 51, 7];
const i = input.shift() ?? 0;

for (let index = 0; index < i; index++) {
	console.log(`${input[index]} ${isPrimeNumber(input[index]) ? "eh primo" : "nao eh primo"}`);
}

function isPrimeNumber(n: number): boolean {
	for (let index = 2; index < n; index++) {
		if (n % index === 0) {
			return false;
		}
	}
	return true;
}
