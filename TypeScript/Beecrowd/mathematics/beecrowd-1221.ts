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

const I = input.shift() ?? 0;

for (let index = 0; index < I; index++) {
	const value = input[index];

	const isPrime = checkIfPrime(value);

	console.log(isPrime ? "Prime" : "Not Prime");
}

function checkIfPrime(N: number): boolean {
	if (N < 2) return false;

	if (N !== 2 && N % 2 === 0) return false;

	const squareRoot = Math.ceil(Math.sqrt(N));

	for (let index = 2; index <= squareRoot; index++) {
		if (index % 2 !== 0) {
			if (N % index === 0) return false;
		}
	}

	return true;
}
