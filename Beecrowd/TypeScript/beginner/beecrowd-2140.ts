import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

let message = "";

const banknotes = [2, 5, 10, 20, 50, 100];

for (const element of input) {
	const [V1, V2] = element.split(" ").map(Number);

	if (V1 === 0 && V2 === 0) break;

	const refund = V2 - V1;

	for (let i = 0; i < banknotes.length; i++) {
		for (let j = 0; j < banknotes.length; j++) {
			if (banknotes[i] + banknotes[j] === refund) {
				message = "possible";
				break;
			}
		}
		if (message !== "") break;
	}
	console.log(message === "" ? "impossible" : message);
	message = "";
}
