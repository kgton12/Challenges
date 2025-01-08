import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = Number.parseInt(readFileSync(stdin.fd, { encoding: "utf8" }));
// const input = 25;

console.log(input * 4);


