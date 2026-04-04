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

for (let index = 0; index < I; index++) {
	const word = input[index].split("");
	const ascCodeArray: number[] = [];
	const charCodeArray: string[] = [];

	word.map((value) => {
		if (isAlphabetic(value)) {
			const ascCode = value.charCodeAt(0) + 3;

			ascCodeArray.push(ascCode);
		} else {
			const ascCode = value.charCodeAt(0);

			ascCodeArray.push(ascCode);
		}
	});

	ascCodeArray.reverse();

	const arrayLength = Number.parseInt((ascCodeArray.length / 2).toString());

	for (let j = arrayLength; j < ascCodeArray.length; j++) {
		ascCodeArray[j] = ascCodeArray[j] - 1;
	}

	ascCodeArray.map((element) => {
		charCodeArray.push(String.fromCharCode(element));
	});

	console.log(charCodeArray.join(""));
}

function isAlphabetic(char: string) {
	return /[a-zA-Z]/.test(char);
}
