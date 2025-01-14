import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);

// const input = ["2", " <..><.<..>>", " <<<..<......<<<<....>"];

const findWord = "<>";
const quantityOfTests = Number.parseInt(input.shift() ?? "");

for (let i = 0; i < quantityOfTests; i++) {
	const result = searchAndDeleteWord(input[i].replace(/\./g, ""), findWord);

	console.log(result);
}

function searchAndDeleteWord(input: string, findWord: string, quantity = 0): number {
	const regex = new RegExp(findWord, "g");

	const quantityFound = (input.match(regex) || []).length + quantity;

	const newWord = input.replace(regex, "");

	const stillExists = newWord.includes(findWord);

	if (stillExists) {
		return searchAndDeleteWord(newWord, findWord, quantityFound);
	}

	return quantityFound;
}
