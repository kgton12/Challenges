import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

// const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);




let i = 1;

while(i <= 9){
    console.log(`I=${i} J=${i+6}`);
    console.log(`I=${i} J=${i+5}`);
    console.log(`I=${i} J=${i+4}`);
    i += 2;
}