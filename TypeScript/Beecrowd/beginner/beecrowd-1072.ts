import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
let numberIn = 0;
let numberOut = 0;

for (let i = 1; i <= input[0]; i++) {
	if (input[i] >= 10 && input[i] <= 20) {
		numberIn++;
	} else {
		numberOut++;
	}
}
console.log(`${numberIn} in`);
console.log(`${numberOut} out`);
