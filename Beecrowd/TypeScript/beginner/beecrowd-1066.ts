import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number).slice(0, -1);
// const input = [6, 0, 3, -4, 12, 0 ].slice(0,-1);

const pair = input.filter((num) => num % 2 === 0).length;
const odd = input.filter((num) => num % 2 !== 0).length;
const positive = input.filter((num) => num > 0).length;
const negative = input.filter((num) => num < 0).length;

console.log(`${pair} valor(es) par(es)`);
console.log(`${odd} valor(es) impar(es)`);
console.log(`${positive} valor(es) positivo(s)`);
console.log(`${negative} valor(es) negativo(s)`);
