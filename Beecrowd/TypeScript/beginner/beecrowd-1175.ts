import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);

// const input = [1, 2, 3, 4, 5];
const newArray: number[] = [];

for (let index = input.length - 1; index >= 0; index--) {
	newArray.push(input[index]);
}

newArray.map((value, index) => {
	console.log(`N[${index}] = ${value}`);
});
