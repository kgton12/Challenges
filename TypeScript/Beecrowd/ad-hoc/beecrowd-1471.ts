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
	const [N, R] = input[index].split(" ").map(Number);

	if (N === 0 || R === 0) break;

	const back = input[index + 1].split(" ").map(Number);
	const notBack: number[] = [];

	if (N === back.length) {
		console.log("*");
	} else {
		for (let index = 1; index <= N; index++) {
			if (!back.includes(index)) {
				notBack.push(index);
			}
		}

		console.log(`${notBack.join(" ")} `);
	}
}
