import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

// const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
const __filename = fileURLToPath(import.meta.url);
const __dirname = dirname(__filename);
const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8")
	.split(EOL)
	.map(Number);

const PI = 3.14;

for (let index = 0; index < input.length; index += 2) {
	if (!input[index]) break;

	const V = input[index];
	const D = input[index + 1];

	const AL = V / (PI * (D / 2.0) ** 2);
	const AR = PI * (D / 2.0) ** 2;

	console.log(`ALTURA = ${AL.toFixed(2)}`);
	console.log(`AREA = ${AR.toFixed(2)}`);
}
