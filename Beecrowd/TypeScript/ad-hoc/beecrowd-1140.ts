import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

for (const element of input) {
	if (element === "*") break;

	const initialLetter = element.substring(0, 1).toLowerCase();
	let isTautograms = true;
	element.split(" ").some((word) => {
		if (word.substring(0, 1).toLowerCase() !== initialLetter) {
			isTautograms = false;
			return;
		}
	});

	console.log(isTautograms ? "Y" : "N");
}
