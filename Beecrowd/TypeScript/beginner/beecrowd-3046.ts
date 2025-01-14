import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = Number.parseInt(readFileSync(stdin.fd, { encoding: "utf8" }));
// const input = 12;
console.log(((input + 1) * (input + 2)) / 2);

//
//((N+1)*(N+2))/2.
