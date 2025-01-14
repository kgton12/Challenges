import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
// const input = [7, 8, 10, 8, 260, 4, 10, 10];

interface IData {
	number: number;
	quantity: number;
}

const data: IData[] = [];

const i = input.shift() ?? 0;

for (let index = 0; index < i; index++) {
	if (data.find((item) => item.number === input[index])) {
		const item = data.find((item) => item.number === input[index]);

		if (item) item.quantity += 1;
	} else {
		data.push({ number: input[index], quantity: 1 });
	}
}

for (const element of data.sort((a, b) => a.number - b.number)) {
	console.log(`${element.number} aparece ${element.quantity} vez(es)`);
}
