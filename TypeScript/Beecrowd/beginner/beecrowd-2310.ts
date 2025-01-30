import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

input.shift();

let [S, B, A, SS, SB, SA] = [0, 0, 0, 0, 0, 0];

for (let index = 0; index < input.length; index += 3) {
	if (input[index + 1] && input[index + 2]) {
		const [s, b, a] = input[index + 1].split(" ").map(Number);
		S += s;
		B += b;
		A += a;

		const [ss, sb, sa] = input[index + 2].split(" ").map(Number);
		SS += ss;
		SB += sb;
		SA += sa;
	}
}

const ssPercentage = S ? (SS / S) * 100 : 0;
const sbPercentage = B ? (SB / B) * 100 : 0;
const saPercentage = A ? (SA / A) * 100 : 0;

console.log(`Pontos de Saque: ${ssPercentage.toFixed(2)} %.`);
console.log(`Pontos de Bloqueio: ${sbPercentage.toFixed(2)} %.`);
console.log(`Pontos de Ataque: ${saPercentage.toFixed(2)} %.`);
