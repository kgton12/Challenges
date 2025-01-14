import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);

// const input = ["0 0 0", "100 100 100"];
const meals = input[0].split(" ").map(Number);
const orders = input[1].split(" ").map(Number);
let sum = 0;

for (let index = 0; index < 3; index++) {
	if (orders[index] > meals[index]) {
		sum += orders[index] - meals[index];
	}
}

console.log(sum);
//
