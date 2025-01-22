import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);

// const input = [
// 	"6",
// 	"100 150 1.0 0",
// 	"90000 120000 5.5 3.5",
// 	"56700 72000 5.2 3.0",
// 	"123 2000 3.0 2.0",
// 	"100000 110000 1.5 0.5",
// 	"62422 484317 3.1 1.0",
// ];

const testCases = Number.parseInt(input.shift() ?? "0");

for (let index = 0; index < testCases; index++) {
	const [populationA, populationB, percentageGrowthA, percentageGrowthB] = input[index].split(" ").map(Number);

	const msg = calculatesPopulationGrowth(populationA, populationB, percentageGrowthA, percentageGrowthB);

	console.log(msg);
}

function calculatesPopulationGrowth(
	populationA: number,
	populationB: number,
	percentageGrowthA: number,
	percentageGrowthB: number,
): string {
	let [localPopulationA, localPopulationB] = [populationA, populationB];
	let years = 0;

	while (localPopulationA <= localPopulationB) {
		localPopulationA += calculatePercentage(localPopulationA, percentageGrowthA);
		localPopulationB += calculatePercentage(localPopulationB, percentageGrowthB);

		years++;

		if (years > 100) break;
	}

	return years > 100 ? "Mais de 1 seculo." : `${Math.round(years)} anos.`;
}

function calculatePercentage(n: number, p: number): number {
	return p === 0 ? 0 : Math.floor(n * (p / 100));
}
