import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const min = Number.parseInt(input.shift() ?? "0");
const minSum = input[0]
	.split(" ")
	.map(Number)
	.reduce((prev, curr) => {
		return prev + curr;
	}, 0);

console.log(minSum > min ? "Deixa para amanha!" : "Farei hoje!");
