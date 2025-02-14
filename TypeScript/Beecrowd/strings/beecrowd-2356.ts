import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

for (let index = 0; index < input.length; index += 2) {
	if (input[index].trim() === "") break;

	const D = input[index];
	const S = input[index + 1];

	console.log(D.includes(S) ? "Resistente" : "Nao resistente");
}
