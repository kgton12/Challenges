import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

let input = Number.parseInt(readFileSync(stdin.fd, { encoding: "utf8" }));
let loop = 1;
while (loop <= 6) {
	if (Math.abs(input) % 2 !== 0) {
		console.log(input);
		loop++;
	}
	input++;
}
