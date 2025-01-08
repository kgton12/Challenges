import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const input = ["3", "1 1", "2 8", "8 2"];
const tests = Number.parseInt(input.shift() ?? "0");

for (let index = 0; index < tests; index++) {
	const [R1, R2] = input[index].split(" ").map(Number);
	console.log(R1 + R2);
}
