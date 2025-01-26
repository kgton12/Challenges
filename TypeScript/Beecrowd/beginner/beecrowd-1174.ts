import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);

interface IData {
	i: number;
	value: string;
}

// const input = [0, -5, 63, -8.5];
const newArray: IData[] = [];

for (let index = 0; index < 100; index++) {
	if (input[index] <= 10) {
		newArray.push({
			i: index,
			value: input[index].toFixed(1),
		});
	}
}

newArray.map((element) => {
	console.log(`A[${element.i}] = ${element.value}`);
});
