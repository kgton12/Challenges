import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(" ").map(Number);
const [C, P, F] = input;

if (C * F <= P) {
	console.log("S");
} else {
	console.log("N");
}
