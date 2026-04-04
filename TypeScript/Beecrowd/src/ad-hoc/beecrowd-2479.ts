import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const I = Number.parseInt(input.shift() ?? "0");
const names: string[] = [];
let sum = 0;
const regex = /[\+\-]/;

for (let index = 0; index < I; index++) {
	if (input[index].includes("+")) {
		sum++;
	}

	names.push(input[index].split(regex)[1].trim());
}

names.sort().map((element) => {
	console.log(element);
});

console.log(`Se comportaram: ${sum} | Nao se comportaram: ${I - sum}`);
