import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const I = Number(input.shift() ?? "0") * 2;

const lastCharacterAlphabet = 91;
const codeAsciiForA = 65;

for (let index = 0; index < I; index += 2) {
	const wordEncrypted = input[index];
	const nextNumber = Number(input[index + 1]);

	const asciiArray = convertWordToAscii(wordEncrypted);

	const wordDecrypted = insertAsciiJump(nextNumber, asciiArray);

	console.log(wordDecrypted);
}

function convertWordToAscii(w: string): number[] {
	const Ascii = w.split("").map((value) => value.charCodeAt(0));

	return Ascii;
}

function insertAsciiJump(jump: number, asciiValues: number[]): string {
	let asciiValuesArray: number[] = [];

	asciiValuesArray = asciiValues.map((value) => {
		if (value - jump < codeAsciiForA) {
			return lastCharacterAlphabet - (codeAsciiForA - (value - jump));
		}

		return value - jump;
	});

	return asciiValuesArray.map((value) => String.fromCharCode(value)).join("");
}
