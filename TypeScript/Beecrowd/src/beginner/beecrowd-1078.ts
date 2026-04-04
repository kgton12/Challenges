import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
// const input = [13];

const number = input[0];

for (let index = 1; index <= 10; index++) {
	console.log(`${index} x ${number} = ${index * number}`);
}
