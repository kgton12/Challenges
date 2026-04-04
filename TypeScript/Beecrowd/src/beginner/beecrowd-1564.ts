import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);

// const input = ['0', '1',' 0', '2', '100', '0'];

for (const element of input) {
	if (!element.trim()) break;

	if (Number.parseInt(element) > 0) {
		console.log("vai ter duas!");
	} else {
		console.log("vai ter copa!");
	}
}
