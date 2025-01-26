import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const input = ["2.0 4.0 8.5 9.0", "6.5", ""];

const notes = input[0].split(" ").map(Number);
const exam = Number(input[1]);

const media = (notes[0] * 2 + notes[1] * 3 + notes[2] * 4 + notes[3] * 1) / 10;

console.log(`Media: ${media.toFixed(1)}`);

if (media >= 7.0) {
	console.log("Aluno aprovado.");
} else if (media < 5.0) {
	console.log("Aluno reprovado.");
} else if (media >= 5.0 && media <= 6.9) {
	console.log("Aluno em exame.");

	console.log(`Nota do exame: ${exam.toFixed(1)}`);

	const newMedia = (media + exam) / 2;

	if (newMedia >= 5.0) {
		console.log("Aluno aprovado.");
	} else {
		console.log("Aluno reprovado.");
	}
	console.log(`Media final: ${newMedia.toFixed(1)}`);
}
