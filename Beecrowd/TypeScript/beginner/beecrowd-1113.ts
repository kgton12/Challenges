import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const input = ['3',
// 	'6.5 4.3 6.2',
// 	'5.1 4.2 8.1',
// 	'8.0 9.0 10.0'];

// const i = Number.parseInt(input[0]);

for (let index = 0; index < input.length; index++) {
	const [n1, n2] = input[index].split(" ").map(Number);

	if (n1 > n2) {
		console.log("Decrescente");
	} else if (n1 < n2) {
		console.log("Crescente");
	} else {
		break;
	}
}
