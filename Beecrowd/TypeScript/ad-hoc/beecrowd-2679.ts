import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = Number.parseInt(readFileSync(stdin.fd, { encoding: "utf8" }));

// const input = 2;
let result = 0;

if (input % 2 === 0) {
	result = input + 2;
} else {
	result = input + 1;
}

console.log(result);
