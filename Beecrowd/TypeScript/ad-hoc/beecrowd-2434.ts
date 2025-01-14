import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);

// const input = ["3 1000", "100", "-800", "50"];

let [days, valueInitial] = input.shift()?.split(" ").map(Number) ?? [0, 0];
let balance = Number.MAX_VALUE;

for (let index = 0; index < days; index++) {
	valueInitial += Number.parseInt(input[index]);

	if (valueInitial < balance) {
		balance = valueInitial;
	}
}
console.log(balance);
