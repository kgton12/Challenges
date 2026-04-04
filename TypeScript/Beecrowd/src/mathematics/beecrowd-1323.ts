import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

for (const element of input.map(Number)) {
	if (element === 0) break;
	let sum = 0;

	for (let index = 1; index <= element; index++) {
		sum += index ** 2;
	}

	console.log(sum);
}
