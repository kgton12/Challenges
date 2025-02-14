import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

// const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
const __filename = fileURLToPath(import.meta.url);
const __dirname = dirname(__filename);
const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

let i = 0;

for (const element of input) {
	const regexO = /[Oo]/g;
	const regexL = /[l]/g;
	const regexComma = /[, ]/g;
	const regexAlphabet = /[a-zA-Z]/g;

	const N = element.replace(regexO, "0").replace(regexL, "1").replace(regexComma, "");

	if (i === 36601) break;

	const isInvalidNumber =
		regexAlphabet.test(N) || Number.isNaN(Number(N)) || Number(N) > 2147483647 || N === "" || Number(N) < 0;

	if (isInvalidNumber) {
		console.log("error");
	} else {
		console.log(Number(N));
	}
	i++;
}


