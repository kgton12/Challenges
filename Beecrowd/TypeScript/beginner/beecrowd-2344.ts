import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
// const input = [12];

const n = input[0];
let response = "";

if (n >= 1 && n <= 35) {
	response = "D";
} else if (n >= 36 && n <= 60) {
	response = "C";
} else if (n >= 61 && n <= 85) {
	response = "B";
} else if (n >= 86 && n <= 100) {
	response = "A";
} else {
	response = "E";
}

console.log(response);
