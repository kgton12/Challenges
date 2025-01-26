import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const I = Number.parseInt(input.shift() ?? "0");
let sum = 0;

for (let index = 0; index < I; index++) {
	const [can, glass] = input[index].split(" ").map(Number);
	sum += can > glass ? glass : 0;
}

console.log(sum);
//
