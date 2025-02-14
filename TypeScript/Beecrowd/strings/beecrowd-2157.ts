import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

// const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
const __filename = fileURLToPath(import.meta.url);
const __dirname = dirname(__filename);
const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const I = Number(input.shift() ?? "0");

for (let index = 0; index < I; index++) {
	const [B, E] = input[index].split(" ").map(Number);
	const responseArray: number[] = [];

	for (let i = B; i <= E; i++) {
		responseArray.push(i);
	}

	const reverseArray = responseArray.map((element) => element.toString().split("").reverse().join("")).reverse();

	const finalResponseArray = [...responseArray, ...reverseArray];

	console.log(finalResponseArray.join(""));
}
