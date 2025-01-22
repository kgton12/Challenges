import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);

// const input = [1, 3, 4, -4, 2, 3, 8, 2, 5, -7, 54, 76, 789, 23, 98];
let oddArray: number[] = [];
let pairArray: number[] = [];
const lengthOfArray = 15;

for (let index = 0; index < lengthOfArray; index++) {
	if (input[index] % 2 === 0) {
		pairArray.push(input[index]);
	} else {
		oddArray.push(input[index]);
	}

	if (oddArray.length === 5 || index === lengthOfArray - 1) {
		oddArray.map((value, index) => {
			console.log(`impar[${index}] = ${value}`);
		});
		oddArray = [];
	}

	if (pairArray.length === 5 || index === lengthOfArray - 1) {
		pairArray.map((value, index) => {
			console.log(`par[${index}] = ${value}`);
		});
		pairArray = [];
	}
}
