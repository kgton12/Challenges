import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const LonelyNumberMap = new Map<number, number>();
const output: number[] = [];

for (let index = 0; index < input.length; index += 2) {
	if (input[index].trim() === "0") break;

	const _ = input[index];
	const numberArray = input[index + 1].split(" ").map(Number);

	for (const element of numberArray) {
		LonelyNumberMap.set(element, (LonelyNumberMap.get(element) ?? 0) + 1);
	}
	output.push(Array.from(LonelyNumberMap).filter((value) => value[1] % 2 !== 0)[0][0]);

	LonelyNumberMap.clear();
}

console.log(output.join(EOL));
