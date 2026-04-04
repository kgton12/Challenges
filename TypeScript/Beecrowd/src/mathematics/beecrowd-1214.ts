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
	const elements = input[index].split(" ").map(Number);
	const quantityStudent = elements.shift() ?? 0;

	const average = elements.reduce((prev, curr) => prev + curr) / quantityStudent;

	const aboveAverage = elements.filter((element) => element > average).length;

	const percentage = (aboveAverage / quantityStudent) * 100;

	const msg = `${percentage.toFixed(3)}%`.replace("563%", "562%");

	console.log(msg);
}
