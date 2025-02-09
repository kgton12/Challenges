import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const I = Number(input.shift() ?? "");

for (let index = 0; index < I; index++) {
	const CurrentInputWord = input[index];

	const half = Math.ceil(CurrentInputWord.length / 2);

	const FirstHalfWord = CurrentInputWord.substring(0, half);
	const SecondHalfWord = CurrentInputWord.substring(half);

	const ReversedFirstHalf = FirstHalfWord.split("").reverse();
	const ReversedSecondHalf = SecondHalfWord.split("").reverse();

	const combinedReversedWords = [...ReversedFirstHalf, ...ReversedSecondHalf];

	console.log(combinedReversedWords.join(""));
}
