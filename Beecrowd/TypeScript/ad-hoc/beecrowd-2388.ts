import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const input = ["3", "10 0", "55 12", "75 120"];

const interval = Number.parseInt(input.shift() ?? "0");
let sum = 0;

for (let index = 0; index < interval; index++) {
	const [time, average] = input[index].split(" ").map(Number);
	sum += time * average;
}
console.log(sum);
