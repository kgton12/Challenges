import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

// const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);

const chosenColumn = Number.parseInt(input[0]);
const operations = input[1].trim();
const headquarters: number[][] = [];

for (let i = 2; i < input.length; i += 12) {
	headquarters.push(input.slice(i, i + 12).map(Number));
}

const column = getColumn();

let result = 0;
if (operations === "S") {
	result = column.reduce((acc, val) => acc + val, 0);
} else if (operations === "M") {
	result = column.reduce((acc, val) => acc + val, 0) / column.length;
}

console.log(result.toFixed(1));

function getColumn(): number[] {
	const newArray: number[] = [];
	for (let index = 0; index < 12; index++) {
		newArray.push(headquarters[index][chosenColumn]);
	}
	return newArray;
}
