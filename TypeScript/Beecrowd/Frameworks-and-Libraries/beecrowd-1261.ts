import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

type ScorePoint = {
	role: string;
	hayPointValor: number;
};

let [positions, testCase] = (input.shift() ?? "0").split(" ").map(Number);
const hayPoint: ScorePoint[] = [];

for (let index = 0; index < positions; index++) {
	const [role, hayPointValor] = input[index].split(" ");

	hayPoint.push({ role, hayPointValor: Number(hayPointValor) });
}

for (let index = 0; index < testCase; index++) {
	const obligations: string[] = [];
	let sum = 0;

	while (positions < input.length) {
		const inputValue = input[positions];
		if (inputValue.trim() === ".") break;

		obligations.push(inputValue);
		positions++;
	}

	for (const element of obligations.join(" ").split(" ")) {
		sum += checkJobExistence(element);
	}
	console.log(sum);
	positions++;
}

function checkJobExistence(str: string): number {
	const jobValue = hayPoint.find((value) => value.role === str)?.hayPointValor ?? 0;
	return jobValue;
}
