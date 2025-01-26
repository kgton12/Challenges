import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const input = ['3',
// 	'6.5 4.3 6.2',
// 	'5.1 4.2 8.1',
// 	'8.0 9.0 10.0'];

// const i = Number.parseInt(input[0]);

for (const element of input) {
	const [x, y] = element.split(" ").map(Number);

	if (x === 0 || y === 0) {
		break;
	}

	if (x > 0 && y > 0) {
		console.log("primeiro");
	} else if (x > 0 && y < 0) {
		console.log("quarto");
	} else if (x < 0 && y < 0) {
		console.log("terceiro");
	} else if (x < 0 && y > 0) {
		console.log("segundo");
	}
}
