import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(" ").map(Number);
// const input = [0, 1, 0, 0];

for (let index = 0; index < 4; index++) {
	if (input[index] === 1) {
		console.log(index + 1);
		break;
	}
}
