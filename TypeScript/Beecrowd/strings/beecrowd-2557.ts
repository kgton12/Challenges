import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const regex = /[+=]/g;

for (const element of input) {
	if (element.trim() === "") break;

	const [R, L, J] = element.split(regex);
	console.log(ruleOfThree(R, L, J));
}

function ruleOfThree(r: string, l: string, j: string): number {
	if (Number.isNaN(Number(r))) {
		return Number(j) - Number(l);
	}

	if (Number.isNaN(Number(l))) {
		return Number(j) - Number(r);
	}

	if (Number.isNaN(Number(j))) {
		return Number(r) + Number(l);
	}

	return 0;
}
