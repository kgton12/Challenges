import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

// const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
const __filename = fileURLToPath(import.meta.url);
const __dirname = dirname(__filename);
const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

let T = 0;
let p = 0;

while (p < input.length) {
	const N = Number.parseInt(input[p++]);

	if (N === 0) break;

	if (T > 0) {
		console.log("");
	}

	const consumptionCounts = Array(201).fill(0);
	let totalX = 0;
	let totalY = 0;

	for (let i = 0; i < N; ++i) {
		const [X, Y] = input[p++].split(" ").map(Number);

		totalX += X;
		totalY += Y;
		consumptionCounts[Math.floor(Y / X)] += X;
	}

	console.log(`Cidade# ${++T}:`);
	const output: string[] = [];

	for (let i = 0; i < 201; ++i) {
		if (consumptionCounts[i] > 0) {
			output.push(`${consumptionCounts[i]}-${i}`);
		}
	}

	console.log(output.join(" "));

	const totalConsumption = Math.floor((100 * totalY) / totalX) / 100;
	console.log(`Consumo medio: ${totalConsumption.toFixed(2)} m3.`);
}
