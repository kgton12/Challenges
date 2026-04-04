import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const starsQuantity = Number.parseInt(input.shift() ?? "0");

const sheepPerStar = input[0].split(" ").map(Number).slice(0, starsQuantity);

const sheepSum = sheepPerStar.reduce((prev, curr) => prev + curr, 0);

let stolenStars = 0;
let returning = 0;

for (let index = 0; index < sheepPerStar.length; index++) {
	const sheep = sheepPerStar[index];

	if (sheep % 2 === 0) {
		const returnToTheStars = sheepPerStar.slice(0, index).filter((value) => value > 1);
		const J = returnToTheStars.length;

		for (let index = J; index >= 0; index--) returning++;
		break;
	}

	if (sheep > 0) stolenStars++;
}

const sheepNotStolen = sheepSum - (stolenStars + returning);

console.log(`${returning > 0 ? stolenStars + 1 : stolenStars} ${sheepNotStolen}`);
