import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const I = Number(input.shift() ?? "0");

for (let index = 0; index < I; index++) {
	const [S1, S2] = input[index].split(" ");

	const isCompatible = fitsOrNotII(S1, S2);

	console.log(isCompatible ? "encaixa" : "nao encaixa");
}

function fitsOrNotII(s1: string, s2: string): boolean {
	if (s2.length > s1.length) return false;

	const chunk = s1.substring(s1.length - s2.length, s1.length);

	return s2 === chunk;
}
