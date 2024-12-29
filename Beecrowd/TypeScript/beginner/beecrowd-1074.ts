import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
// const input = [3,0,-1,4];

for (let index = 1; index <= input[0]; index++) {
	let result = "";

	if (input[index] % 2 === 0) {
		if (input[index] > 0) {
			result += "EVEN POSITIVE";
		} else if (input[index] < 0) {
			result += "EVEN NEGATIVE";
		} else {
			result += "NULL";
		}
	} else {
		if (input[index] > 0) {
			result += "ODD POSITIVE";
		} else {
			result += "ODD NEGATIVE";
		}
	}
	console.log(result);
}
