import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const input = ['3',
// 	'6.5 4.3 6.2',
// 	'5.1 4.2 8.1',
// 	'8.0 9.0 10.0'];

const i = Number.parseInt(input[0]);

for (let index = 1; index <= i; index++) {
	const numberArray = input[index].toString().split(" ").map(Number);

	const result = (numberArray[0] * 0.2 + numberArray[1] * 0.3 + numberArray[2] * 0.5).toFixed(1);
	console.log(result);
}
