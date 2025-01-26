import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const input = ["3 5", "fechou", "fechou", "clicou", "clicou", "clicou"];

let [init, totalActions] = (input.shift() ?? "").split(" ").map(Number);

for (let index = 0; index < totalActions; index++) {
	if (input[index] === "fechou") {
		init++;
	} else {
		init--;
	}
}

console.log(init);
