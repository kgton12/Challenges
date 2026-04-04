import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(" ").map(Number);
// const input = [4.5, -2.2];

const [x, y] = input;

if (x === 0 && y !== 0) {
	console.log("Eixo Y");
} else if (x !== 0 && y === 0) {
	console.log("Eixo X");
} else if (x > 0 && y > 0) {
	console.log("Q1");
} else if (x < 0 && y > 0) {
	console.log("Q2");
} else if (x < 0 && y < 0) {
	console.log("Q3");
} else if (x > 0 && y < 0) {
	console.log("Q4");
} else if (x === 0 && y === 0) {
	console.log("Origem");
}
