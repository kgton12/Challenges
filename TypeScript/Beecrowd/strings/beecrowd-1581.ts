import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

// const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
const __filename = fileURLToPath(import.meta.url);
const __dirname = dirname(__filename);
const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const I = Number(input.shift() ?? "0");
let index = 0;
let caseQuantity = 0;

while (caseQuantity < I) {
	const J = Number(input[index]);

	const nationality: string[] = [];

	for (let i = 0; i < J; i++) {
		nationality.push(input[index + i + 1]);
	}

	const talkAbout = removeDistinctValues(nationality).length === 1 ? nationality[0] : "ingles";

	console.log(talkAbout);

	index += J + 1;
	caseQuantity++;
}

function removeDistinctValues(arr: string[]): string[] {
	const seen = {};
	const distinctArray: string[] = [];

	for (let i = 0; i < arr.length; i++) {
		if (!seen[arr[i]]) {
			distinctArray.push(arr[i]);
			seen[arr[i]] = true;
		}
	}

	return distinctArray;
}
