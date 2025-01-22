import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const i = Number.parseInt(input.shift() ?? "0");

const arrayInput = input[0].split(" ").map(Number).slice(0, i);

for (let index = 2; index < 6; index++) {
	console.log(
		`${arrayInput.reduce((prev, cur) => {
			return prev + (cur % index === 0 ? 1 : 0);
		}, 0)} Multiplo(s) de ${index}`,
	);
}
