import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const regex = /[+*]/;
const memory = Number.parseInt(input.shift() ?? "0");
const [N1, N2] = input.length ? input[0].split(regex).map(Number) : [0, 0];
const isMultiply = input[0].includes("*");

if (isMultiply) {
	console.log(N1 * N2 > memory ? "OVERFLOW" : "OK");
} else {
	console.log(N1 + N2 > memory ? "OVERFLOW" : "OK");
}
//
