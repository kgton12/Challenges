import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const [N, M] = (input.shift() ?? "0 0").split(" ").map(Number);
const data: number[][] = [];

for (let index = 0; index < N; index++) {
	data.push(input[index].split(" ").map(Number));
}

const [I, J] = findTheLightSaber(data);

console.log(`${I} ${J}`);

function findTheLightSaber(data: number[][]): number[] {
	for (let i = 1; i < N - 1; i++) {
		for (let j = 1; j < M - 1; j++) {
			if (
				data[i][j] === 42 &&
				data[i - 1][j - 1] === 7 &&
				data[i - 1][j] === 7 &&
				data[i - 1][j + 1] === 7 &&
				data[i][j - 1] === 7 &&
				data[i][j + 1] === 7 &&
				data[i + 1][j - 1] === 7 &&
				data[i + 1][j] === 7 &&
				data[i + 1][j + 1] === 7
			) {
				return [i + 1, j + 1];
			}
		}
	}

	return [0, 0];
}
