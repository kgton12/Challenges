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

const inputData = readFileInput();

const input = inputData.split(EOL).map(Number);

const I = Number(input.shift() ?? "0");
const output: number[] = [];

for (let index = 0; index < I; index++) {
	const element = input[index];
	output.push(element % 2 === 0 ? 0 : 1);
}

console.log(output.join(EOL));
