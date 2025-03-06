import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { join } from "node:path";
import { stdin } from "node:process";

function readFileInput(): string {
	if (process.env.NODE_ENV === "TEST") {
		return readFileSync(join(process.cwd(), "file.txt"), "utf-8");
	}
	return readFileSync(stdin.fd, { encoding: "utf8" });
}

const inputData = readFileInput().split(EOL).map(Number);
const output: string[] = [];

for (let index = 0; index < inputData.length; index++) {
	const I = inputData[index];

	const times: number[] = [];

	for (let j = 0; j < I; j++) {
		index++;

		times.push(inputData[index]);
	}

	if (times.length > 0) output.push(Math.min(...times).toFixed(2));
}

console.log(output.join(EOL));
