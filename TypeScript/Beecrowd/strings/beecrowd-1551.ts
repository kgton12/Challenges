import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const I = Number(input.shift() ?? "0");

const alphabetSize = 26;

for (let index = 0; index < I; index++) {
	const inputValues = input[index].split("");

	const arrLettersLength = distinctLetter(justLetters(inputValues)).length;

	if (arrLettersLength === alphabetSize) {
		console.log("frase completa");
	} else if (arrLettersLength >= alphabetSize / 2) {
		console.log("frase quase completa");
	} else {
		console.log("frase mal elaborada");
	}
}

function distinctLetter(arr: string[]): string[] {
	const letterExists = {};
	const distinctArr: string[] = [];

	for (const element of arr) {
		if (!letterExists[element]) {
			distinctArr.push(element);
			letterExists[element] = true;
		}
	}

	return distinctArr;
}

function justLetters(arr: string[]): string[] {
	const arrLetters: string[] = [];
	const [letterA, letterZ] = [65, 90];

	for (const element of arr) {
		const charCodeAscii = element.toLocaleUpperCase().charCodeAt(0);

		if (charCodeAscii >= letterA && charCodeAscii <= letterZ) {
			arrLetters.push(String.fromCharCode(charCodeAscii));
		}
	}

	return arrLetters;
}
