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
let firstCase = true;

while (index < input.length) {
	const quantityLines = Number(input[index]);

	if (quantityLines === 0) break;

	index++;

	const words: string[] = [];

	for (let j = 0; j < quantityLines; j++) {
		words.push(input[index + j]);
	}

	const formattedWords = formatWordToTheRight(words);

	if (!firstCase) console.log("");
	firstCase = false;

	formattedWords.map((value) => console.log(value));

	index += quantityLines;
}

function formatWordToTheRight(words: string[]) {
	const biggestWord = words.reduce((prev, curr) => {
		return prev.length > curr.length ? prev : curr;
	}, "").length;

	return words.map((value) => value.padStart(biggestWord, " "));
}
