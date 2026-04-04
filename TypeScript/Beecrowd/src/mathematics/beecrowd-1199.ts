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
const output: string[] = [];

for (const element of inputData) {
	if (element.trim() === "-1") break;

	const isHex = element.includes("x");

	const value = isHex ? convertHexForDec(element) : convertDecForHex(Number(element));

	output.push(value);
}

console.log(output.join(EOL));

function convertDecForHex(n: number): string {
	return `0x${n.toString(16).toUpperCase()}`;
}
function convertHexForDec(n: string): string {
	return Number.parseInt(n, 16).toString();
}
