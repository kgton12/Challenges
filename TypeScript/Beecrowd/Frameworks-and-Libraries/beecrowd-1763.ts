import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const christmasGreetings = [
	{ country: "brasil", phrase: "Feliz Natal!" },
	{ country: "alemanha", phrase: "Frohliche Weihnachten!" },
	{ country: "austria", phrase: "Frohe Weihnacht!" },
	{ country: "coreia", phrase: "Chuk Sung Tan!" },
	{ country: "espanha", phrase: "Feliz Navidad!" },
	{ country: "grecia", phrase: "Kala Christougena!" },
	{ country: "estados-unidos", phrase: "Merry Christmas!" },
	{ country: "inglaterra", phrase: "Merry Christmas!" },
	{ country: "australia", phrase: "Merry Christmas!" },
	{ country: "portugal", phrase: "Feliz Natal!" },
	{ country: "suecia", phrase: "God Jul!" },
	{ country: "turquia", phrase: "Mutlu Noeller" },
	{ country: "argentina", phrase: "Feliz Navidad!" },
	{ country: "chile", phrase: "Feliz Navidad!" },
	{ country: "mexico", phrase: "Feliz Navidad!" },
	{ country: "antardida", phrase: "Merry Christmas!" },
	{ country: "canada", phrase: "Merry Christmas!" },
	{ country: "irlanda", phrase: "Nollaig Shona Dhuit!" },
	{ country: "belgica", phrase: "Zalig Kerstfeest!" },
	{ country: "italia", phrase: "Buon Natale!" },
	{ country: "libia", phrase: "Buon Natale!" },
	{ country: "siria", phrase: "Milad Mubarak!" },
	{ country: "marrocos", phrase: "Milad Mubarak!" },
	{ country: "japao", phrase: "Merii Kurisumasu!" },
];

for (const element of input) {
	if (element.trim() === "") break;

	const response = christmasGreetings.filter((value) => value.country === element)[0];

	if (response) console.log(response.phrase);
	else console.log("--- NOT FOUND ---");
}
