import { info } from "node:console";
import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const quantityOfClothes = input.length ? Number.parseInt(input.shift() ?? "0") : 0;
const [washerMin, washerMax] = input.length ? (input.shift()?.split(" ").map(Number) ?? [0, 0]) : [0, 0];
const [dryerMin, dryerMax] = input.length ? (input.shift()?.split(" ").map(Number) ?? [0, 0]) : [0, 0];

console.log(
	quantityOfClothes >= washerMin &&
		quantityOfClothes <= washerMax &&
		quantityOfClothes >= dryerMin &&
		quantityOfClothes <= dryerMax
		? "possivel"
		: "impossivel",
);
