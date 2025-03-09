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

const inputData = readFileInput().split(EOL);

const I = Number(inputData.shift() ?? "0");
const output: number[] = [];

for (let index = 0; index < I; index++) {
	const values = inputData[index].split(" ").map(Number);

	const numberOfPlayers = values.shift() ?? 0;
	const captainInArray = Math.trunc(numberOfPlayers / 2);
	const ageCaptain = Number(values[captainInArray]);
	output.push(ageCaptain);
}

output.map((value, index) => console.log(`Case ${index + 1}: ${value}`));
