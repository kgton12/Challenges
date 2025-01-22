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

const sumSeconds: number[] = [];

sumSeconds.push(input[1] * 2 + input[2] * 4);

sumSeconds.push(input[0] * 2 + input[2] * 2);

sumSeconds.push(input[0] * 4 + input[1] * 2);

console.log(Math.min(...sumSeconds));
