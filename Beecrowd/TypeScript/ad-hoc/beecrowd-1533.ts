import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

for (let index = 0; index < input.length; index += 2) {
	const N = input[index].split(" ").map(Number);

	if (N.length === 1 && N[0] === 0) {
		break;
	}

	const suspects = input[index + 1].split(" ").map(Number);

	findKiller(suspects);
}

function findKiller(caseData: number[]) {
	const suspectList = caseData;
	const secondMostSuspicious = [...suspectList].sort((a, b) => b - a)[1];
	const suspectIndex = suspectList.indexOf(secondMostSuspicious) + 1;

	console.log(suspectIndex);
}
