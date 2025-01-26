import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

let index = 0;

while (index < input.length) {
	const M = input[index].split(" ");

	if ([input[index].trim(), M[0].trim()].includes("")) break;

	if (M.length === 1) {
		const quantityShoes = Number.parseInt(M[0]);
		const initial = index + 1;
		const final = initial + quantityShoes;

		const shoesList = input.slice(initial, final);

		const result = countCorrectPairs(shoesList);

		index += quantityShoes;

		console.log(result);
	}

	index++;
}

function countCorrectPairs(shoeList: string[]) {
	const leftShoes: { [key: string]: number } = {};
	const rightShoes: { [key: string]: number } = {};

	for (const element of shoeList) {
		const [size, side] = element.split(" ");
		if (side === "E") {
			leftShoes[size] = (leftShoes[size] || 0) + 1;
		} else if (side === "D") {
			rightShoes[size] = (rightShoes[size] || 0) + 1;
		}
	}

	let correctPairs = 0;
	for (const size in leftShoes) {
		if (rightShoes[size]) {
			correctPairs += Math.min(leftShoes[size], rightShoes[size]);
		}
	}

	return correctPairs;
}
