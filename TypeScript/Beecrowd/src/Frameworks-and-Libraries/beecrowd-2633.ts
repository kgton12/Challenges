import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

let index = 0;

type BarbecueItems = {
	meat: string;
	validate: number;
};

while (input[index].trim() !== "") {
	const meatQuantity = Number(input[index]);
	const barbecueItemsList: BarbecueItems[] = [];

	for (let j = 0; j < meatQuantity; j++) {
		const [meat, validate] = input[++index].split(" ");

		barbecueItemsList.push({ meat, validate: Number(validate) });
	}

	const result = barbecueItemsList
		.sort((a, b) => a.validate - b.validate)
		.map((item) => item.meat)
		.join(" ");

	console.log(result);
	index++;
}
