import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const direction = ["N", "L", "S", "O"];
let directionIndex = 0;

for (let index = 0; index < input.length; index += 2) {
	const i = Number.parseInt(input[index]);
	if (i === 0) break;

	const orders = input[index + 1].split("").slice(0, i);

	orders.map((order) => {
		directionIndex = order === "D" ? directionIndex + 1 : directionIndex - 1;
	});

	const result = getDirection(directionIndex);
	console.log(result);
	directionIndex = 0;
}

function getDirection(index: number): string {
	const I = ((index % direction.length) + direction.length) % direction.length;
	return direction[I];
}
