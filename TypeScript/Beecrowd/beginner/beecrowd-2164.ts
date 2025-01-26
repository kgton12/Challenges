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

const N = input.shift() ?? 0;

const FibonacciN = (((1 + Math.sqrt(5)) / 2) ** N - ((1 - Math.sqrt(5)) / 2) ** N) / Math.sqrt(5);

console.log(FibonacciN.toFixed(1));
