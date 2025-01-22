import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const operations = input.shift() ?? 0;
const arrayInput = input.map(Number);
const arrayOfNumber: number[] = [];
let sum = 0;

const multiple = 12;

for (let i = 1; i <= 5; i++) {
	for (let j = 0; j < i; j++) {
		arrayOfNumber.push(arrayInput[multiple * i + j]);
	}
}

let aux = 5;
for (let i = 6; i < 11; i++) {
	for (let j = 0; j < aux; j++) {
		arrayOfNumber.push(arrayInput[multiple * i + j]);
	}
	aux--;
}

sum =
	operations === "S"
		? arrayOfNumber.reduce((prev, curr) => {
				return prev + curr;
			}, 0)
		: arrayOfNumber.reduce((prev, curr) => {
				return prev + curr;
			}, 0) / arrayOfNumber.length;

console.log(sum.toFixed(1));
