import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

processValues(input[0], input[1]);

function processValues(value1: string, value2: string): void {
	const numericValue1 = removeNonNumeric(value1);
	const numericValue2 = removeNonNumeric(value2);

	const cpf = numericValue1.slice(0, 11);
	const remainingValue1 = numericValue1.slice(11);

	const numValue1 = Number.parseFloat(remainingValue1) ?? 0;
	const numValue2 = Number.parseFloat(numericValue2) ?? 0;

	const result = truncateToTwoDecimals(numValue1 + numValue2);

	console.log(`cpf ${cpf}`);
	console.log(result);
}

function removeNonNumeric(str: string): string {
	return str.replace(/[^\d.]/g, "");
}

function truncateToTwoDecimals(num: number): string {
	return (Math.floor(num * 100) / 100).toFixed(2);
}
