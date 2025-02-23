import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

for (const element of input) {
	const endLine = element.trim().split(" ").length;
	if (endLine === 1) break;

	const [Q, D, P] = element.split(" ").map(Number);
	const pages = Number.parseInt(((Q * D * P) / (P - Q)).toString());
	const stringPage = pages > 1 ? "paginas" : "pagina";
	console.log(`${pages} ${stringPage}`);
}
