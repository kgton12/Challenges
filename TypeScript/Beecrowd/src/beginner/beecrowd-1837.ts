import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" });
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8");

const [A, B] = input.split(" ").map(Number);

console.log(calculate(A, B));

function calculate(x: number, y: number): string {
	let Q = 0;

	if (x > 0)
		if (y > 0) Q = Math.floor(x / y);
		else Q = Math.ceil(x / y);
	else if (y > 0) Q = Math.floor(x / y);
	else Q = Math.ceil(x / y);

	return `${Q} ${x - y * Q}`;
}
