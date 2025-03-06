import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const I = Number(input.shift() ?? "0") * 2;
let closestAttempt = Number.MAX_SAFE_INTEGER;
let response = 0;

for (let index = 0; index < I; index += 2) {
	const [numberOfPlayer, drawnNumber] = input[index].split(" ").map(Number);

	const attempts = input[index + 1].split(" ").map(Number).slice(0, numberOfPlayer);

	for (const element of attempts) {
		const result = element - drawnNumber < 0 ? (element - drawnNumber) * -1 : element - drawnNumber;

		if (result < closestAttempt) {
			closestAttempt = result;
			response = element;
		}
	}
	closestAttempt = Number.MAX_SAFE_INTEGER;
	console.log(attempts.indexOf(response) + 1);
}
