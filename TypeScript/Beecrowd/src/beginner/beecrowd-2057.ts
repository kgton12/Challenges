import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const [S, T, F] = input[0].split(" ").map(Number);
const sum = S + T + F;

if (sum >= 24) {
	console.log(sum - 24);
} else if (sum < 0) {
	console.log(sum + 24);
} else {
	console.log(sum);
}
