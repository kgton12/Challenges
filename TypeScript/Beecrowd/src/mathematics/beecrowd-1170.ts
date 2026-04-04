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
	const result = calculateAmountOfFood(input[index]);

	console.log(`${result} dias`);
}

function calculateAmountOfFood(K: number): number {
	let kilos = K;
	let count = 0;

	while (kilos > 1) {
		kilos = kilos / 2;
		count++;
	}

	return count;
}
