import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

let biggerWord = "";

for (const element of input) {
	if (element.trim() === "0") break;

	const words = element.split(" ");

	const phrase = words
		.map((element) => {
			biggerWord = element.length >= biggerWord.length ? element : biggerWord;

			return element.length;
		})
		.join("-");

	console.log(phrase);
}

console.log(" ");
console.log(`The biggest word: ${biggerWord}`);
