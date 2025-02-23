import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

// const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
const __filename = fileURLToPath(import.meta.url);
const __dirname = dirname(__filename);
const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

input.pop();

class TShirt {
	name: string;
	color: string;
	length: string;

	constructor(n: string, c: string, l: string) {
		this.name = n;
		this.color = c;
		this.length = l;
	}
}

const comp = (a: TShirt, b: TShirt) => {
	if (a.color === b.color) {
		if (a.length === b.length) {
			if (a.name < b.name) return -1;
			if (a.name > b.name) return 1;
			return 0;
		}
		if (a.length > b.length) return -1;
		return 1;
	}
	if (a.color < b.color) return -1;
	return 1;
};

let first = true;
while (input.length) {
	const N = Number.parseInt(input.shift() ?? "0");

	if (first) first = false;
	else console.log("");

	const tShirts: TShirt[] = [];
	for (let i = 0; i < N; ++i) {
		const name = (input.shift() ?? "").trim();
		const [color, length] = (input.shift() ?? "").trim().split(" ");

		tShirts.push(new TShirt(name, color, length));
	}

	tShirts.sort(comp);

	tShirts.map((value) => console.log(`${value.color} ${value.length} ${value.name}`));
}
