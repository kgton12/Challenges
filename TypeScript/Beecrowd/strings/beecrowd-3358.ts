import { fork } from "node:child_process";
import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const vowel = ["a", "e", "i", "o", "u"];

const I = Number(input.shift() ?? "");

for (let index = 0; index < I; index++) {
	const name = input[index];

	const isHardName = threeConsecutiveConsonants(name);

	console.log(isHardName ? `${name} nao eh facil` : `${name} eh facil`);
}

function threeConsecutiveConsonants(n: string): boolean {
	let quantity = 0;

	for (const element of n) {
		if (!vowel.includes(element.toLocaleLowerCase())) {
			quantity++;
		} else {
			quantity = 0;
		}

		if (quantity === 3) return true;
	}

	return false;
}
