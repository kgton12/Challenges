import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);

for (let index = 1; index <= input[0]; index++) {
	if (index % 2 === 0) {
		console.log(`${index}^2 = ${index ** 2}`);
	}
}
