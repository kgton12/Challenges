import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

// const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
const __filename = fileURLToPath(import.meta.url);
const __dirname = dirname(__filename);
const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

let i = 0;
while (i < input.length) {
	if (input[i].trim() === "") {
		break;
	}

	const n = Number(input[i]);

	i += 1;

	const codes: string[] = [];

	for (let j = 0; j < n; j++) {
		codes.push(input[i]);
		i += 1;
	}
	codes.sort();
	codes.map((code) => console.log(code));
}
