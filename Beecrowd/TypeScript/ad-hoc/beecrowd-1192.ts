import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const i = Number.parseInt(input.shift() ?? "0");

for (let index = 0; index < i; index++) {
	const [V1, W, V3] = input[index].split("");

	const N1 = Number.parseInt(V1);
	const N2 = Number.parseInt(V3);

	if (N1 === N2) {
		console.log(N1 * N2);
	} else if (isUpperCase(W)) {
		console.log(N2 - N1);
	} else {
		console.log(N1 + N2);
	}
}

function isUpperCase(w: string): boolean {
	return w === w.toUpperCase();
}
