import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);

const chosenLine = Number.parseInt(input[0]);
const operations = input[1].trim();
const headquarters: number[][] = [];

for (let i = 2; i < input.length; i += 12) {
	headquarters.push(input.slice(i, i + 12).map(Number));
}

const line = headquarters[chosenLine];

let result = 0;
if (operations === "S") {
	result = line.reduce((acc, val) => acc + val, 0);
} else if (operations === "M") {
	result = line.reduce((acc, val) => acc + val, 0) / line.length;
}

console.log(result.toFixed(1));
