import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const N = Number(input.shift() ?? "0");
const ALP = (input.shift() ?? "0").split(" ").map(Number);
let fits = true;

for (const element of ALP) {
	if (element < N) fits = false;
}

console.log(`${fits ? "S" : "N"}`);
