import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const input = ["1 544768710", "2 538533133", "3 38884958", "0 0"];

for (let index = 0; index < input.length; index++) {
	const [quantity, xp] = input[index].split(" ").map(Number);

	if (quantity === 0 && xp === 0) {
		break;
	}

	console.log(quantity * xp);
}
