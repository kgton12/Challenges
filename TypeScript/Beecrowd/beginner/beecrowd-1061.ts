import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const regex = /[^0-9]/g;
const initDay = (input.shift() ?? "").replace(regex, "").padStart(2, "0");
const [initHour, initMinutes, initSeconds] = (input.shift() ?? "")
	.split(":")
	.map((element) => element.trim().padStart(2, "0"));

const endDay = (input.shift() ?? "").replace(regex, "").padStart(2, "0");
const [endHour, endMinutes, endSeconds] = (input.shift() ?? "")
	.split(":")
	.map((element) => element.trim().padStart(2, "0"));

const initTimeStamp = new Date(`2025-01-${initDay}T${initHour}:${initMinutes}:${initSeconds}.000Z`);
const endTimeStamp = new Date(`2025-01-${endDay}T${endHour}:${endMinutes}:${endSeconds}.000Z`);

const t = Math.abs(endTimeStamp.getTime() - initTimeStamp.getTime());

const days = Math.floor(t / (1000 * 60 * 60 * 24));
const hours = Math.floor((t % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
const minutes = Math.floor((t % (1000 * 60 * 60)) / (1000 * 60));
const seconds = Math.floor((t % (1000 * 60)) / 1000);

console.log(`${days} dia(s)`);
console.log(`${hours} hora(s)`);
console.log(`${minutes} minuto(s)`);
console.log(`${seconds} segundo(s)`);
