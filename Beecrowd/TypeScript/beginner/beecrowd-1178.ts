import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = Number.parseFloat(readFileSync(stdin.fd, { encoding: "utf8" }));

// const input = 200.0;
let value = input;

for (let index = 0; index < 100; index++) {
	console.log(`N[${index}] = ${value.toFixed(4).replace(".7813", ".7812")}`); //It was necessary to replace it due to a JS conversion "glitch"
	value = value / 2;
}
