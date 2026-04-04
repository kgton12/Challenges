import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8")
// 	.split(EOL)
// 	.map(Number);

const pair: number[] = [];
const odd: number[] = [];
const I = Number(input.shift() ?? "0");
const elementsArray = input.slice(0, I);

for (const element of elementsArray) {
	if (element.toString().trim() === "") break;

	if (element % 2 === 0) {
		pair.push(element);
	} else {
		odd.push(element);
	}
}

const fullArray = [...pair.sort((a, b) => a - b), ...odd.sort((a, b) => b - a)];

fullArray.map((element) => console.log(element));
