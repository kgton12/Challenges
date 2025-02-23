import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);

// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8")
// 	.split(EOL)
// 	.map(Number);

for (const element of input) {
	if (element.toString().trim() === "" || element === 0) break;
	constructTree(element);
}

function constructTree(n: number): void {
	let space = 0;
	const asterisk = "*";

	for (let index = 1; index <= n; index += 2) {
		space = (n - index) / 2;
		const s = `${" ".repeat(space)}${asterisk.repeat(index)}`;
		console.log(s);
	}

	for (let index = 1; index <= 3; index += 2) {
		space = (n - index) / 2;
		const s = `${" ".repeat(space)}${asterisk.repeat(index)}`;
		console.log(s);
	}

	console.log("");
}
