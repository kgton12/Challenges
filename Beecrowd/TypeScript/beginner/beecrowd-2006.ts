import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const input = ["3", "4 1 1 2 1"];
const tea = Number.parseInt(input[0]);
const quantityCorrectAnswer = input[1]
	.split(" ")
	.map(Number)
	.filter((competitor) => competitor === tea).length;

console.log(quantityCorrectAnswer);
