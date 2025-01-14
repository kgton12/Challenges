import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);

// const input = ["3", "5 3", "8 2", "5 6", "2", "5 5", "0 0", "0"];

interface IOgType {
	a: number;
	b: number;
}

const data: IOgType[] = [];

for (const element of input) {
	const [a, b] = element.split(" ").map(Number);

	data.push({ a, b });
}

for (let index = 0; index < data.length; index++) {
	if (data[index].b === undefined) {
		if (data[index].a === 0) break;
		processingOg(data.slice(index + 1, data[index].a + index + 1));
	}
}

function processingOg(data: IOgType[]) {
	let A = 0;
	let B = 0;

	for (const element of data) {
		if (element.a > element.b) {
			A++;
		} else if (element.a < element.b) {
			B++;
		}
	}
	console.log(`${A} ${B}`);
}
