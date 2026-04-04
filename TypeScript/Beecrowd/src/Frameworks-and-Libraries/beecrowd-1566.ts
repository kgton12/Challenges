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

for (let index = 0; index < I; index += 2) {
	const quantityPeople = Number(input[index]);
	const heightOfPeople = input[index + 1]
		.split(" ")
		.slice(0, quantityPeople)
		.map(Number)
		.sort((a, b) => a - b)
		.join(" ");

	console.log(heightOfPeople);
}
