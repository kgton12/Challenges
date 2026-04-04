import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

type Sort = {
	number: number;
	mod: number;
};

const array: Sort[] = [];
const output: string[] = [];

for (let index = 0; index < input.length; index++) {
	const [quantityNumber, mod] = input[index].split(" ").map(Number);

	if (quantityNumber === 0 && mod === 0) break;

	for (let j = 0; j < quantityNumber; j++) {
		index++;

		const N = Number(input[index]);

		array.push({ number: N, mod: N % mod });
	}

	array.sort(sortByModAndNumber);

	output.push(`${quantityNumber} ${mod}`);
	output.push(array.map((value) => value.number).join(EOL));
	array.length = 0;
}

output.push("0 0");
console.log(output.join(EOL));

function sortByModAndNumber(a: Sort, b: Sort): number {
	if (a.mod !== b.mod) {
		return a.mod - b.mod;
	}

	if (a.number % 2 !== 0 && b.number % 2 !== 0) {
		return b.number - a.number;
	}

	if (a.number % 2 === 0 && b.number % 2 === 0) {
		return a.number - b.number;
	}

	return a.number % 2 !== 0 ? -1 : 1;
}
