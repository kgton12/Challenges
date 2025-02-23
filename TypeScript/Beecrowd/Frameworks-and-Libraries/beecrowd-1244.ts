import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const I = Number(input.shift() ?? "0");

const wordArray = input.slice(0, I);

for (const element of wordArray) {
	console.log(orderWordsBySize(element));
}
function orderWordsBySize(str: string): string {
	const strArray = str.split(" ");

	const orderedStrArray = strArray.map((value) => {
		return { length: value.length, value };
	});

	return orderedStrArray
		.sort((a, b) => b.length - a.length)
		.map((value) => value.value)
		.join(" ");
}
