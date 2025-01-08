import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
const [C, N] = input[0].split(" ").map(Number);
const endPoint = C % N;
console.log(endPoint);
