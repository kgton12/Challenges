import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

// const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
const __filename = fileURLToPath(import.meta.url);
const __dirname = dirname(__filename);
const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const I = Number.parseInt(input.shift() ?? "0");

for (let index = 0; index < I; index++) {
	const lines = input.slice(index * 3, index * 3 + 3);

	processBattleOfPomekons(lines);
}

function processBattleOfPomekons(data: string[]): void {
	const bonus = Number.parseInt(data[0]);

	const [AD, DD, LD] = data[1].split(" ").map(Number);
	const [AG, DG, LG] = data[2].split(" ").map(Number);

	const blowValueD = (AD + DD) / 2 + (LD % 2 === 0 ? bonus : 0);
	const blowValueG = (AG + DG) / 2 + (LG % 2 === 0 ? bonus : 0);

	if (blowValueD > blowValueG) {
		console.log("Dabriel");
	} else if (blowValueG > blowValueD) {
		console.log("Guarte");
	} else {
		console.log("Empate");
	}
}
