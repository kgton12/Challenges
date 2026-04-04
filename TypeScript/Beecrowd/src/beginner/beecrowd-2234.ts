import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(" ").map(Number);

// const input = [10, 90];
const [H, P] = input;
console.log((H / P).toFixed(2));
