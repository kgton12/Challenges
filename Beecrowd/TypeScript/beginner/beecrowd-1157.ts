import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = Number.parseInt(readFileSync(stdin.fd, { encoding: "utf8" }));
// const input = 6;

for (let index = 1; index <= input; index++) {
	if (input % index === 0) {
		console.log(index);
	}
}