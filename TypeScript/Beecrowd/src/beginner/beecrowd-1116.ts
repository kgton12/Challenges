import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const input = ["3", "3 -2", "-8 0", "0 8"];

const i = Number.parseInt(input[0]);

for (let index = 1; index <= i; index++) {
	const [n1, n2] = input[index].split(" ").map(Number);

	if (n2 === 0) {
		console.log("divisao impossivel");
	} else {
		console.log((n1 / n2).toFixed(1));
	}
}
