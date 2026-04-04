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

const I = Number(input.shift() ?? "0");
const queries = input.slice(0, I);
const output: string[] = [];

const maxElement = Math.max(...queries);

const fibArray: number[] = [];
fibArray[0] = 0;
fibArray[1] = 1;
for (let i = 2; i <= maxElement; i++) {
	fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
}

for (const element of queries) {
	output.push(`Fib(${element}) = ${fibArray[element]}`);
}

console.log(output.join(EOL));
