import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin, uptime } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

let isCharacterUppercase = false;

for (const element of input) {
	if (element.trim() === "") break;

	const wordDancing = element.split("").map((value) => {
		return invertCharacterCase(value);
	});

	isCharacterUppercase = false;

	console.log(wordDancing.join(""));
}

function invertCharacterCase(inputString: string): string {
	if (inputString.trim() === "") return inputString;

	if (/[a-zA-Z]/.test(inputString)) {
		isCharacterUppercase = !isCharacterUppercase;
		return isCharacterUppercase ? inputString.toUpperCase() : inputString.toLowerCase();
	}

	return inputString;
}
