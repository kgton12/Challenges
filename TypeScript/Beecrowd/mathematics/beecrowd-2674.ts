import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8")
// 	.split(EOL)
// 	.map(Number);

const output: string[] = [];

const Response = {
	PRIME: "Primo",
	SUPER: "Super",
	NORMAL: "Nada",
};

for (const element of input) {
	if (Number.isNaN(element) || element === 0) break;

	const isPrime = isPrimeNumber(element);

	if (isPrime) {
		isSuperPrimeNumber(element) ? output.push(Response.SUPER) : output.push(Response.PRIME);
	} else {
		output.push(Response.NORMAL);
	}
}

console.log(output.join(EOL));

function isPrimeNumber(n: number): boolean {
	if (n < 2) return false;

	const square = Math.trunc(Math.sqrt(n));

	for (let index = 2; index <= square; index++) {
		if (n % index === 0) return false;
	}

	return true;
}

function isSuperPrimeNumber(n: number): boolean {
	return n
		.toString()
		.split("")
		.every((digit) => isPrimeNumber(Number(digit)));
}
