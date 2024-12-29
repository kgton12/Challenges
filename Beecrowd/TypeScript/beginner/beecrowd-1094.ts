import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const input = ['3',
// 	'6.5 4.3 6.2',
// 	'5.1 4.2 8.1',
// 	'8.0 9.0 10.0'];

const quantity = Number.parseInt(input[0]);
let mouse = 0;
let frog = 0;
let rabbit = 0;

for (let index = 1; index <= quantity; index++) {
	const [animalQuantity, animalType] = input[index].split(" ");
	if (animalType === "C") {
		rabbit += Number.parseInt(animalQuantity);
	} else if (animalType === "R") {
		mouse += Number.parseInt(animalQuantity);
	} else {
		frog += Number.parseInt(animalQuantity);
	}
}

const total = mouse + frog + rabbit;

console.log(`Total: ${total} cobaias`);
console.log(`Total de coelhos: ${rabbit}`);
console.log(`Total de ratos: ${mouse}`);
console.log(`Total de sapos: ${frog}`);
console.log(`Percentual de coelhos: ${calculatePercentage(rabbit, total)} %`);
console.log(`Percentual de ratos: ${calculatePercentage(mouse, total)} %`);
console.log(`Percentual de sapos: ${calculatePercentage(frog, total)} %`);

function calculatePercentage(value: number, total: number): string {
	return ((value / total) * 100).toFixed(2);
}
