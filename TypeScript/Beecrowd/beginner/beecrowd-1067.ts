import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = Number.parseInt(readFileSync(stdin.fd, { encoding: "utf8" }));

for (let i = 1; i <= input; i++) {
	if (i % 2 !== 0) {
		console.log(i);
	}
}
