import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

// const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
const __filename = fileURLToPath(import.meta.url);
const __dirname = dirname(__filename);
const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const numbersList: number[] = [];

for (let index = 0; index < 3; index++) {
	numbersList.push(Number.parseInt(input[index]));
}

const [A, B, C] = numbersList.map(String);

console.log(`A = ${A}, B = ${B}, C = ${C}`);

console.log(`A = ${A.padStart(10, " ")}, B = ${B.padStart(10, " ")}, C = ${C.padStart(10, " ")}`);

const formatNumber = (num: string): string => {
	const parsedNum = Number.parseInt(num);
	return parsedNum < 0 ? `-${(parsedNum * -1).toString().padStart(9, "0")}` : num;
};

const FormattedNumberA = formatNumber(A);
const FormattedNumberB = formatNumber(B);
const FormattedNumberC = formatNumber(C);

console.log(
	`A = ${FormattedNumberA.padStart(10, "0")}, B = ${FormattedNumberB.padStart(10, "0")}, C = ${FormattedNumberC.padStart(10, "0")}`,
);

console.log(`A = ${A.padEnd(10, " ")}, B = ${B.padEnd(10, " ")}, C = ${C.padEnd(10, " ")}`);
