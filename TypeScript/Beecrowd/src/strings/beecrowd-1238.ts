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
	const [A, B] = input[index].split(" ");

	const mixedWord: string[] = [];

	const biggestWord = Math.max(A.length, B.length);

	for (let j = 0; j < biggestWord; j++) {
		if (A.charAt(j) !== "") mixedWord.push(A.charAt(j));

		if (B.charAt(j) !== "") mixedWord.push(B.charAt(j));
	}

	console.log(mixedWord.join(""));
}
