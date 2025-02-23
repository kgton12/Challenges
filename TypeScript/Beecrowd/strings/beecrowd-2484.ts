import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { pipeline } from "node:stream";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

for (let index = 0; index < input.length; index++) {
	if (input[index].trim() === "") break;

	const word = input[index];

	const triangleWordArray = generateTriangleWords(word);

	triangleWordArray.map((element) => console.log(element));

	console.log(" ");
}

function generateTriangleWords(word: string): string[] {
	const wordArray: string[] = [];
	const wordLength = word.length;

	for (let index = 0; index < wordLength; index++) {
		const w = word
			.substring(0, wordLength - index)
			.split("")
			.map((value, index) => {
				return index !== 0 ? ` ${value}` : value;
			});
		for (let i = 0; i < index; i++) {
			w.unshift(" ");
		}

		wordArray.push(w.join(""));
	}

	return wordArray;
}
//
