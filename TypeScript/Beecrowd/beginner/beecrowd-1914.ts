import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const i = Number.parseInt(input.shift() ?? "0") * 2;

for (let index = 0; index < i; index += 2) {
	const [player1, player1Chose] = input[index].split(" ").slice(0, 2);
	const [player2] = input[index].split(" ").slice(2, 4);

	const oddOrPair =
		input[index + 1]
			.split(" ")
			.map(Number)
			.reduce((prev, curr) => {
				return prev + curr;
			}) %
			2 ===
		0
			? "PAR"
			: "IMPAR";

	if (oddOrPair === player1Chose.toUpperCase()) {
		console.log(player1);
	} else {
		console.log(player2);
	}
}
