import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { join } from "node:path";
import { stdin } from "node:process";

function readFileInput(): string {
	if (process.env.NODE_ENV === "TEST") {
		return readFileSync(join(process.cwd(), "file.txt"), "utf-8");
	}
	return readFileSync(stdin.fd, { encoding: "utf8" });
}

const inputData = readFileInput().split(EOL);
const output: string[] = [];

for (let index = 0; index < inputData.length; index++) {
	if (inputData[index].trim() === "" || inputData[index].trim() === "0") break;

	const I = Number(inputData[index]);

	let yearSendMessage = Number.MAX_SAFE_INTEGER;
	let planetName = "";

	for (let j = 0; j < I; j++) {
		index++;
		const [planet, year, time] = inputData[index].split(" ");

		if (Number(year) - Number(time) < yearSendMessage) {
			yearSendMessage = Number(year) - Number(time);
			planetName = planet;
		}
	}

	output.push(planetName);
}

console.log(output.join(EOL));
