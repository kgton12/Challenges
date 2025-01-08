import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);

console.log(fibonacci(input[0]));

function fibonacci(n: number): string {
	const fib = [0, 1];
	for (let i = 2; i < n; i++) {
		fib[i] = fib[i - 1] + fib[i - 2];
	}
	return fib.slice(0, n).join(" ");
}

