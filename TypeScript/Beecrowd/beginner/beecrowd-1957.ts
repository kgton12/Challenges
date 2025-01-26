import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = Number.parseInt(readFileSync(stdin.fd, { encoding: "utf8" }));
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = Number.parseInt(readFileSync(join(__dirname, "..", "file.txt"), "utf-8"));

const hexDigits = ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"];

let remainingInput = input;
let resultQuotient = -1;
let output = "";

while (remainingInput > 0) {
    resultQuotient = Math.floor(remainingInput / 16);
    const remainder = remainingInput % 16;
    output = hexDigits[remainder] + output;
    remainingInput = resultQuotient;
}

console.log(output);