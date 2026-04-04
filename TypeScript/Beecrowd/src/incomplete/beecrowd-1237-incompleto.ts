import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

// const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
const __filename = fileURLToPath(import.meta.url);
const __dirname = dirname(__filename);
const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const output: string[] = [];

for (let index = 0; index < input.length; index += 2) {
	const word1 = input[index];
	const word2 = input[index + 1];

	if (word1.trim() === "") break;

	const result = substringComparison(word1, word2);
	output.push(result.toString());
}

console.log(output.join(EOL));

function substringComparison(w1: string, w2: string): number {
	let result = 0;

	for (let index = 0; index < w2.length; index++) {
		const substring = w2.substring(index, index + 1);

		if (w1.includes(substring)) result = 1;
	}

	for (let index = 1; index < w2.length; index++) {
		const substring = w2.substring(0, index);

		if (w1.includes(substring)) result = index;
	}

	return result;
}
