import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(" ").map(Number);
// const input = [3, -1, 0, -2, 2];

const numbersProcessed = input.filter((value) => value > 0);
const A = numbersProcessed[0];
const N = numbersProcessed[1];

let soma = 0;
for (let i = 0; i < N; i++) {
	soma += A + i;
}

console.log(soma);
