import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
// const input = [30, 18];
//

const [typedPressure, currentPressure] = input;

console.log(typedPressure - currentPressure);
