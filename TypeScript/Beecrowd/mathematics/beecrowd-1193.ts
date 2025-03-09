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

const Base = {
	DEC: "dec",
	HEX: "hex",
	BIN: "bin",
};

type ResultBaseConversion = {
	conversion1: string;
	conversion2: string;
};

const inputData = readFileInput().split(EOL);

const output: ResultBaseConversion[] = [];

const I = Number(inputData.shift() ?? "0");

for (let index = 0; index < I; index++) {
	const [number, base] = inputData[index].split(" ");

	convertToBase(number, base);
}

output.forEach((value, index) => {
	console.log(`Case ${index + 1}:`);
	console.log(value.conversion1);
	console.log(value.conversion2);
	console.log("");
});

function convertToBase(n: string, actualBase: string): void {
	let value1 = "";
	let value2 = "";

	switch (actualBase) {
		case Base.BIN:
			value1 = convertBinForDec(n);
			value2 = convertDecForHex(value1);
			output.push({
				conversion1: `${value1} ${Base.DEC}`,
				conversion2: `${value2} ${Base.HEX}`,
			});
			break;
		case Base.DEC:
			value1 = convertDecForHex(n);
			value2 = convertDecForBin(n);
			output.push({
				conversion1: `${value1} ${Base.HEX}`,
				conversion2: `${value2} ${Base.BIN}`,
			});
			break;
		case Base.HEX:
			value1 = convertHexForDec(n);
			value2 = convertDecForBin(value1);
			output.push({
				conversion1: `${value1} ${Base.DEC}`,
				conversion2: `${value2} ${Base.BIN}`,
			});
			break;
		default:
			console.error(`Invalid base provided: ${actualBase}`);
	}
}

function convertDecForHex(n: string): string {
	return Number(n).toString(16).toLocaleLowerCase();
}

function convertDecForBin(n: string): string {
	return Number(n).toString(2);
}

function convertBinForDec(n: string): string {
	return Number.parseInt(n, 2).toString();
}

function convertHexForDec(n: string): string {
	return Number.parseInt(n, 16).toString();
}
