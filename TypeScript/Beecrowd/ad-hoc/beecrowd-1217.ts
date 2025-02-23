import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const I = Number(input.shift() ?? "0") * 2;
let monetarySum = 0;
let fruitSum = 0;
let days = 0;

for (let index = 0; index < I; index += 2) {
	const fruits = input[index + 1];

	monetarySum += Number(input[index]);
	fruitSum += fruits.split(" ").length;

	days++;

	console.log(`day ${days}: ${fruits.split(" ").length} kg`);
}

const kiloAverage = fruitSum / (I / 2);
const monetaryAverage = monetarySum / days;

console.log(`${kiloAverage.toFixed(2)} kg by day`);
console.log(`R$ ${monetaryAverage.toFixed(2)} by day`);
