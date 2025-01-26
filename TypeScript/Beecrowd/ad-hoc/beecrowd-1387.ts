import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);

// const input = ["2 2", "2 3", "5 5", "1 1", "0 0"];
for (const element of input) {
	const [L, R] = element.split(" ").map(Number);

	if (L === 0 && R === 0) {
		break;
	}

	console.log(L + R);
}
