import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
// const input = [0, -5, 63, 0];

const newArray = input.map((element) => (element < 1 ? 1 : element));

newArray.map((element, index) => console.log(`X[${index}] = ${element}`));
