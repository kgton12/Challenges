import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

for (const element of input) {
	if (element.trim() === "") break;

	const [H, A] = element.split(" ").map(Number);

	let result = H - A;

	result = result < 0 ? result * -1 : result;

	console.log(result);
}
