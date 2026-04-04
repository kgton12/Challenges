import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

class Stack {
	items: number[];
	minStack: number[];
	output: string[];

	constructor(output: string[]) {
		this.items = [];
		this.minStack = [];
		this.output = output;
	}

	Push(n: number) {
		this.items.push(n);
		if (this.minStack.length === 0 || n <= this.getMin()) {
			this.minStack.push(n);
		}
	}

	Pop() {
		if (this.items.length > 0) {
			const removed = this.items.pop();
			if (removed === this.getMin()) {
				this.minStack.pop();
			}
		} else {
			this.output.push("EMPTY");
		}
	}

	getMin() {
		return this.minStack[this.minStack.length - 1];
	}

	Min() {
		if (this.items.length > 0) {
			this.output.push(String(this.getMin()));
		} else {
			this.output.push("EMPTY");
		}
	}
}

const output: string[] = [];
const I = Number(input.shift() ?? "0");
const array: Stack = new Stack(output);
const commands = {
	PUSH: "PUSH",
	POP: "POP",
	MIN: "MIN",
};

for (let index = 0; index < I; index++) {
	const [action, value] = input[index].split(" ");
	switch (action) {
		case commands.PUSH:
			array.Push(Number(value));
			break;
		case commands.POP:
			array.Pop();
			break;
		case commands.MIN:
			array.Min();
			break;
		default:
			break;
	}
}

console.log(output.join(EOL));
