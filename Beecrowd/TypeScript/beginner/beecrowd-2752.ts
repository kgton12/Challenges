import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

// const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
const word = "AMO FAZER EXERCICIO NO URI";

console.log(`<${word}>`); // Format %s
console.log(`<${word.padStart(30, " ")}>`); // Format %30s
console.log(`<${word.substring(0, 20)}>`); // Format %.20s
console.log(`<${word.padEnd(20, " ")}>`); // Format %-20s
console.log(`<${word.padEnd(30, " ")}>`); // Format %-30s
console.log(`<${word.substring(0, 30)}>`); // Format %.30s
console.log(`<${word.substring(0, 20).padStart(30, " ")}>`); // Format %30.20s
console.log(`<${word.substring(0, 20).padEnd(30, " ")}>`); // Format %-30.20s
