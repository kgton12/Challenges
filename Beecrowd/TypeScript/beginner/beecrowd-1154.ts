import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
// const input = [34, 56, 44, 23, -2];
const values: number[] = [];

for (const element of input) {
	if (element > 0) {
		values.push(element);
	} else break;
}

const sum = values.reduce((acc, cur) => acc + cur, 0) / values.length;
console.log(sum.toFixed(2));