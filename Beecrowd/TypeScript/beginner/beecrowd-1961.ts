import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

let answer = "";
const [lengthOfJump, numberOfPipes] = input[0].split(" ").map(Number);
const arrayInput = input[1].split(" ").map(Number).slice(0, numberOfPipes);

for (let index = 0; index < numberOfPipes - 1; index++) {
	const actualPipe = arrayInput[index];
	const nextPipe = arrayInput[index + 1];

	if (Math.abs(actualPipe - nextPipe) > lengthOfJump) {
		answer = "GAME OVER";
		break;
	}
}

console.log(answer === "" ? "YOU WIN" : answer);
