import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(" ").map(Number);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(" ").map(Number);

const [D1, D2, D3] = input;

console.log(checkMood(D1, D2, D3));

function checkMood(D1: number, D2: number, D3: number): string {
	if (D1 > D2 && (D2 < D3 || D2 === D3)) return ":)";

	if (D1 < D2 && (D2 > D3 || D2 === D3)) return ":(";

	if (D1 < D2 && D2 < D3 && D3 - D2 < D2 - D1) return ":(";

	if (D1 < D2 && D2 < D3 && D3 - D2 >= D2 - D1) return ":)";

	if (D1 > D2 && D2 > D3 && D2 - D3 < D1 - D2) return ":)";

	if (D1 > D2 && D2 > D3 && D2 - D3 >= D1 - D2) return ":(";

	if (D1 === D2 && D2 < D3) return ":)";

	if (D1 === D2 && D2 > D3) return ":(";

	return ":(";
}
