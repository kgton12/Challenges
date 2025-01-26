import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(" ").map(Number);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8")
// 	.split(" ")
// 	.map(Number);

const sortedInAscending = input.slice().sort((a, b) => a - b);
const sortedInDescending = input.slice().sort((a, b) => b - a);

if (compareArrays(input, sortedInAscending)) {
	console.log("C");
} else if (compareArrays(input, sortedInDescending)) {
	console.log("D");
} else {
	console.log("N");
}

function compareArrays(firstArray: number[], secondArray: number[]): boolean {
	return JSON.stringify(firstArray) === JSON.stringify(secondArray);
}
