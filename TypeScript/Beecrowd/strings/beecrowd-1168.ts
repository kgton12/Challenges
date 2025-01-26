import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).trim().split(EOL);
const quantityLed = [6, 2, 5, 5, 4, 5, 6, 3, 7, 6];
// const input = ["3", "115380", "2819311", "23456"];

const i = Number.parseInt(input.shift() ?? "");

for (let index = 0; index < i; index++) {
	const arrayNumber = input[index].split("").map(Number);

	const sumLeds = arrayNumber.reduce((acc, cur) => acc + quantityLed[cur], 0);

	console.log(`${sumLeds} leds`);
}
