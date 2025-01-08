import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
// const input = [10, 18];

const [min, max] = input.filter((value) => value > 0).sort((a, b) => a - b);

for (let index = min + 1; index < max; index++) {
	if (index % 5 === 2 || index % 5 === 3) {
		console.log(index);
	}
}
