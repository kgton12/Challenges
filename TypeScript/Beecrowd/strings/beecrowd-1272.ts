import { info } from "node:console";
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

let hiddenMessage: string[] = [];

for (let index = 0; index < I; index++) {
	const slicedWord = input[index].split(" ").map((value) => value.trim());

	for (const word of slicedWord) {
		hiddenMessage.push(word.split("")[0]);
	}

	console.log(hiddenMessage.join(""));
	hiddenMessage = [];
}
