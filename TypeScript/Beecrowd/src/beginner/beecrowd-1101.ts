import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const input = ["5 2", "6 3", "4 8", "-1 1", "0 0", ""];

for (let index = 0; index < input.length; index++) {
	if (input[index].indexOf("0") >= 0 || input[index].indexOf("-") >= 0) {
		input.splice(index);
		break;
	}
}

for (let index = 0; index < input.length; index++) {
	const [initial, final] = input[index]
		.split(" ")
		.map(Number)
		.sort((a, b) => a - b);

	let sum = 0;
	const numbers: number[] = [];
	for (let j = initial; j <= final; j++) {
		sum += j;
		numbers.push(j);
	}
	console.log(numbers.join(" "), `Sum=${sum}`);
}
