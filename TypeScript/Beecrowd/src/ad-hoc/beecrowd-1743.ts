import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const plug = (input.shift() ?? "0").split(" ").map(Number);
const socket = (input.shift() ?? "0").split(" ").map(Number);

let isCompatible = true;

for (let index = 0; index < 5; index++) {
	if (plug[index] === socket[index]) isCompatible = false;
}

console.log(isCompatible ? "Y" : "N");
