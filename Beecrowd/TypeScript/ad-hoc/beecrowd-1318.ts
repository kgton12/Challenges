import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);
let duplicateElements: number[] = [];

for (let index = 0; index < input.length; index += 2) {
	const [N, M] = input[index].split(" ").map(Number);

	if (N === 0 && M === 0) {
		break;
	}

	const arr = input[index + 1].split(" ").map(Number);

	for (const element of arr) {
		if (arr.filter((el) => el === element).length > 1 && duplicateElements.includes(element) === false) {
			duplicateElements.push(element);
		}
	}
	console.log(duplicateElements.length);
	duplicateElements = [];
}
