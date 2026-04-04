import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

type Student = {
	name: string;
	region: string;
	cost: number;
};

const input = readFileSync("/dev/stdin", "utf8").split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8")
// 	.split(EOL);

const output: string[] = [];

let i = 0;
while (i < input.length) {
	const I = Number(input[i].trim());

	if (Number.isNaN(I) || I === 0) break;

	const studentsArray: Student[] = [];

	for (let index = 0; index < I; index++) {
		i++;
		const [name, region, cost] = input[i].split(" ");
		studentsArray.push({ name, region, cost: Number(cost) });
	}

	output.push(
		studentsArray
			.sort(sortStudents)
			.map((value) => value.name.trim())
			.join(EOL),
	);

	i++;
}

console.log(output.join(EOL));

function sortStudents(a: Student, b: Student) {
	const costDiff = a.cost - b.cost;
	if (costDiff !== 0) {
		return costDiff;
	}

	const regionDiff = a.region.localeCompare(b.region);
	if (regionDiff !== 0) {
		return regionDiff;
	}

	return a.name.localeCompare(b.name);
}
