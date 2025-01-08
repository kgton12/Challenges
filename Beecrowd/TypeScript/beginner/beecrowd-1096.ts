import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

// const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);

let i = 1;
const j = 7;

while (i <= 9) {
	console.log(`I=${i} J=${j}`);
	console.log(`I=${i} J=${j - 1}`);
	console.log(`I=${i} J=${j - 2}`);
	i += 2;
}
