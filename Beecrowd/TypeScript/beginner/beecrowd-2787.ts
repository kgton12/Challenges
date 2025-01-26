import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const [L, C] = [input[0], input[1]].map(Number);
const Chess: number[][] = [];
let bool = true;

for (let i = 0; i < L; i++) {
	Chess[i] = [];
	for (let j = 0; j < C; j++) {
		Chess[i][j] = bool ? 1 : 0;
		bool = !bool;
	}
	if (Chess[i][0] === 1) {
		bool = false;
	} else {
		bool = true;
	}
}

console.log(Chess[L - 1][C - 1]);
