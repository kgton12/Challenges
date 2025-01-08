import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
let sum = 0;

for (let index = 0; index < input[0]; index++) {
	console.log(`${sum + 1} ${sum + 2} ${sum + 3} PUM`);
	sum += 4;
}
