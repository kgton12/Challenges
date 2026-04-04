import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);

for (const element of input) {
	if (element.trim() === "") break;

	const [M, N] = element.split(" ").map(Number);

	const totalFactorialSum = calculateFactorial(BigInt(M)) + calculateFactorial(BigInt(N));
	console.log(totalFactorialSum.toString());
}

function calculateFactorial(InputNumber: bigint): bigint {
	if (InputNumber === BigInt(0) || InputNumber === BigInt(1)) return BigInt(1);

	let result = BigInt(1);
	for (let i = BigInt(2); i <= InputNumber; i++) {
		result *= i;
	}
	return result;
}
