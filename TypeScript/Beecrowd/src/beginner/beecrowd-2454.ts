import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8")
// 	.split(" ").map(Number);

const [P, R] = input;
let response = "";

if (P === 0) response = "C";

if (P === 1) {
	if (R === 0) response = "B";
	else response = "A";
}

console.log(response);
