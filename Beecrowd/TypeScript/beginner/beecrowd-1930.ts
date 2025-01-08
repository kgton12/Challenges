import { readFileSync } from "node:fs";
// import { EOL } from "node:os"
import { stdin } from "node:process";

const powerRulers: number[] = readFileSync(stdin.fd, { encoding: "utf8" }).split(" ").map(Number);
const total = powerRulers.reduce((acc, powerRuler) => {
	return acc + powerRuler;
}, -3);

console.log(total);
