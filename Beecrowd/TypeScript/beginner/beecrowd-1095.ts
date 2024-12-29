import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
// const input = ['3',
// 	'6.5 4.3 6.2',
// 	'5.1 4.2 8.1',
// 	'8.0 9.0 10.0'];

// const i = Number.parseInt(input[0]);
let i = 1;
let j = 60;

while (j >= 0) {
	console.log(`I=${i} J=${j}`);
	j -= 5;
	i += 3;
}
