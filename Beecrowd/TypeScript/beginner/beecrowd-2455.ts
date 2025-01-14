import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(" ").map(Number);
// const input = [30, 100, 60, 50];

const [P1, C1, P2, C2] = input;
const L1 = P1 * C1;
const L2 = P2 * C2;

if (L1 === L2) {
	console.log(0);
} else if (L1 < L2) {
	console.log(1);
} else {
	console.log(-1);
}
