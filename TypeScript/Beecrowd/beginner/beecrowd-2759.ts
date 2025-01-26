import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const [W0, W1, W2] = input;

console.log(`A = ${W0}, B = ${W1}, C = ${W2}`);
console.log(`A = ${W1}, B = ${W2}, C = ${W0}`);
console.log(`A = ${W2}, B = ${W0}, C = ${W1}`);
