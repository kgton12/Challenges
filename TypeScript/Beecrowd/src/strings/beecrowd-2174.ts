import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const I = Number(input.shift() ?? "0");
const quantityPokemon = 151;

const pokemon = input.slice(0, I);

const numberOfPokemonDistinct = distinctPokemon(pokemon).length;

console.log(`Falta(m) ${quantityPokemon - numberOfPokemonDistinct} pomekon(s).`);

function distinctPokemon(arr: string[]): string[] {
	const letterExists = {};
	const distinctArr: string[] = [];

	for (const element of arr) {
		if (!letterExists[element]) {
			distinctArr.push(element);
			letterExists[element] = true;
		}
	}

	return distinctArr;
}
