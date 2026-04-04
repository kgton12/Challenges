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
	const [D, N] = element.split(" ");

	if (D === "0" && N === "0") break;

	const regex = new RegExp(D, "g");

	const result = BigInt(N.replace(regex, ""));

	console.log(result.toString());
}
