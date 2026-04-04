import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = Number.parseInt(readFileSync(stdin.fd, { encoding: "utf8" }));

// const input = 4;
let i = 0;

for (let index = 0; index < 1000; index++) {
	console.log(`N[${index}] = ${i}`);

	if (i === input - 1) {
		i = 0;
	} else {
		i++;
	}
}
