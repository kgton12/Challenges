import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

let index = 0;
let first = true;

while (index < input.length) {
	const I = Number(input[index]);
	const arrayWords: string[] = [];

	if (I === 0) break;

	index++;

	if (!first) {
		console.log("");
	}

	for (let i = 0; i < I; i++) {
		arrayWords.push(input[index + i]);
	}

	const responseArray = leftPadStrings(normalizeStringArray(arrayWords));

	responseArray.map((value) => console.log(value));

	index += I;
	first = false;
}

function normalizeStringArray(arr: string[]): string[] {
	return arr.map((element) => {
		const wordsArray = element.split(" ").filter((value) => value.trim() !== "");
		return wordsArray.join(" ");
	});
}

function leftPadStrings(arr: string[]): string[] {
	const maxLength = Math.max(...arr.map((value) => value.length));
	return arr.map((value) => value.padStart(maxLength, " "));
}
