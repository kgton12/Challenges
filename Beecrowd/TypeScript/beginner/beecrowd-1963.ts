import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" });
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8");

const [oldValue, newValue] = input.split(" ").map(Number);
const percentage = ((newValue - oldValue) / oldValue) * 100;

console.log(`${percentage.toFixed(2)}%`);
