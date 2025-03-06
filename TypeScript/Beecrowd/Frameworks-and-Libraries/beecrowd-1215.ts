import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const words = new Set<string>();
const regex = /[^a-zA-Z]/g;
const maxLength = 5000;

for (const element of input) {
	if (element.trim() === "") continue;

	const arrayWords = element.replace(regex, " ").split(" ");

	for (const arrayWord of arrayWords) {
		if (arrayWord.trim() !== "") {
			words.add(arrayWord.toLocaleLowerCase().trim());
		}
	}
}

Array.from(words)
	.sort((a, b) => a.localeCompare(b))
	.slice(0, maxLength)
	.map((value) => console.log(value));
