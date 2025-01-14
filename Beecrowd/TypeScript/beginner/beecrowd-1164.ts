import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);

// const input = [3, 6, 5, 28];
const i = input.shift() ?? 0;
let arrayElements: number[] = [];

for (let index = 0; index < i; index++) {

	const element = input[index];
	for (let index = 1; index < element; index++) {
		if (element % index === 0) {
			arrayElements.push(index);
		}
	}

	console.log(isPerfectNumber(arrayElements, element) ? `${element} eh perfeito` : `${element} nao eh perfeito`);
    arrayElements=[];
}

function isPerfectNumber(arr: number[], n: number): boolean {
	const sum = arr.reduce((prev, cur) => {
		return prev + cur;
	}, 0);

	return sum === n;
}
