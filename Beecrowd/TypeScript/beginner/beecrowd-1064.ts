import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
// const input = [7, -5, 6, -3.4, 4.6, 12];

const positiveNumbers = input.filter((element) => element > 0);
const average = positiveNumbers.reduce((acc, element) => acc + element, 0) / positiveNumbers.length;

console.log(`${positiveNumbers.length} valores positivos`);
console.log(average.toFixed(1));
