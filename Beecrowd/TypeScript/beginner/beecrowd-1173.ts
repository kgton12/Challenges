import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

// const input = Number.parseInt(readFileSync(stdin.fd, { encoding: "utf8" }));

const input = 5;
let i = input;
for (let index = 0; index < 10; index++) {
	console.log(`N[${index}] = ${i}`);

	i = i * 2;
}
