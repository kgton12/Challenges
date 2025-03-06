import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

// const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
const __filename = fileURLToPath(import.meta.url);
const __dirname = dirname(__filename);
const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const T = Number(input.shift() ?? "0");

for (let i = 0; i < T; i++) {
	const S = input.shift() ?? "";
	const Q = Number(input.shift() ?? "0");

	for (let j = 0; j < Q; j++) {
		const R = input.shift() ?? "";

		let si = 0;
		let ri = 0;

		while (si < S.length && ri < R.length) {
			if (S[si] === R[ri]) {
				ri++;
			}
			si++;
		}

		if (ri === R.length) {
			console.log("Yes");
		} else {
			console.log("No");
		}
	}
}
