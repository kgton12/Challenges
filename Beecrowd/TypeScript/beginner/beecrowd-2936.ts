import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
// const input = [3, 7, 8, 1, 5, 0];
const array = input.slice(0, 5);
const gramsPerPerson = [300, 1500, 600, 1000, 150];
let sum = 0;

for (let index = 0; index < array.length; index++) {
	sum += input[index] * gramsPerPerson[index];
}

sum += 225;
console.log(sum);
