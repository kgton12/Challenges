import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);

// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const choseAlternative = ["A", "B", "C", "D", "E"];

let index = 0;
while (index < input.length) {
	if (input[index] === "0") {
		break;
	}

	const n = Number.parseInt(input[index]);
	index++;

	for (let i = 0; i < n; i++) {
		const alternatives = input[index]?.split(" ").map(Number) ?? [];
		index++;
		const chosen: number[] = [];

		for (let j = 0; j < alternatives.length; j++) {
			if (alternatives[j] <= 127) {
				chosen.push(j);
			}
		}

		if (chosen.length === 1) {
			console.log(choseAlternative[chosen[0]]);
		} else {
			console.log("*");
		}
	}
}
