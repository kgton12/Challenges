import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const Quantity = Number(input.shift() ?? "0");
const quest = (input.shift() ?? "0").split(" ").map(Number).slice(0, Quantity);
let yesResp = 0;
let noResp = 0;

for (const element of quest) {
	if (element === 0) {
		yesResp++;
	} else {
		noResp++;
	}
}

console.log(yesResp > noResp ? "Y" : "N");
