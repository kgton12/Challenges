import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = Number.parseInt(readFileSync(stdin.fd, { encoding: "utf8" }));
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = Number.parseInt(readFileSync(join(__dirname, "..", "file.txt"), "utf-8"));

console.log(`Feliz nat${"a".repeat(input)}l!`);
