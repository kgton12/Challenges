import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const I = Number(input.shift() ?? "0");

for (let index = 0; index < I; index++) {
	const element = Number(input[index]);

	const kilos = calculateKilos(element);

	console.log(`${kilos} kg`);
}

function calculateKilos(e: number): number {
	let sum = 1;

	for (let J = 0; J < e; J++) {
		sum = sum * 2;
	}

	const grams = sum / 12;

	const kilos = Number.parseInt((grams / 1000).toString());

	return kilos;
}
