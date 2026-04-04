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
const output: number[] = [];

const I = Number(inputData.shift() ?? "0");

for (let index = 0; index < I; index++) {
	const [X, Y] = inputData[index].split(" ").map(Number);

	const result = Math.trunc((X * Y) / 2);
	output.push(result);
}

output.map((value) => console.log(`${value} cm2`));
