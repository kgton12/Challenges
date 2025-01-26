import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(" ").map(Number);

// const input = [10, 30, 20, 5, 0];
let bigger = 0;

for (const element of input) {
	if (element === 0) {
		break;
	}

	bigger = element > bigger ? element : bigger;
}

console.log(bigger);
