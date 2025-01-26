import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);

// const input = [1196, 23, 0];

const [min, max] = input.filter((value) => value > 0).sort((a, b) => a - b);

let sum = 0;

for (let index = min; index <= max; index++) {
	if (index % 13 !== 0) {
		sum += index;
	}
}

console.log(sum);
