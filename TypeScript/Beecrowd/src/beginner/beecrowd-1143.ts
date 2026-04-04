import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);

for (let index = 1; index <= input[0]; index++) {
	console.log(`${index ** 1} ${index ** 2} ${index ** 3}`);
}
