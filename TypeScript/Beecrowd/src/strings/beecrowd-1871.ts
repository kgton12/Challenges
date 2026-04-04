import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

// const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
const __filename = fileURLToPath(import.meta.url);
const __dirname = dirname(__filename);
const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

for (const element of input) {
	const [M, N] = element.split(" ").map(Number);

	if (M === 0 && N === 0) break;

	const regex = /0/g;

	const formattedSum = (M + N).toString().replace(regex, "");

	console.log(formattedSum);
}
