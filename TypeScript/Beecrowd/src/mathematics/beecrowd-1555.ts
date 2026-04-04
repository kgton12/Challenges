import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const Student = {
	Rafael: 1,
	Beto: 2,
	Carlos: 3,
} as const;

type Student = (typeof Student)[keyof typeof Student];

const I = Number.parseInt(input.shift() ?? "0");

for (let index = 0; index < I; index++) {
	const [X, Y] = input[index].split(" ").map(Number);
	let bigger = 0;
	let name = "";

	const B = calculateFunctionValue(X, Y, Student.Beto);
	const R = calculateFunctionValue(X, Y, Student.Rafael);
	const C = calculateFunctionValue(X, Y, Student.Carlos);

	bigger = Math.max(B, R, C);

	if (bigger === B) {
		name = "Beto";
	} else if (bigger === R) {
		name = "Rafael";
	} else {
		name = "Carlos";
	}

	console.log(`${name} ganhou`);
}

function calculateFunctionValue(X: number, Y: number, student: Student): number {
	let result = 0;

	switch (student) {
		case Student.Beto:
			result = 2 * X ** 2 + (5 * Y) ** 2;
			break;
		case Student.Carlos:
			result = -100 * X + Y ** 3;
			break;
		case Student.Rafael:
			result = (3 * X) ** 2 + Y ** 2;
			break;
		default:
			break;
	}

	return result;
}
