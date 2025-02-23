import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

type FinalNumber = {
	B1: number;
	B2: number;
};

for (const element of input) {
	if (element.trim() === "") break;
	const isValid = validateCPF(element);
	console.log(isValid ? "CPF valido" : "CPF invalido");
}

function validateCPF(cpf: string): boolean {
	const regex = /[^0-9]/g;
	let fullCPF = "";

	const sanitizeCPF = cpf.replace(regex, "");

	const finalNumber = extractFinalNumber(sanitizeCPF);
	fullCPF = sanitizeCPF.slice(0, 9) + finalNumber.B1.toString() + finalNumber.B2.toString();

	return fullCPF === sanitizeCPF;
}

function extractFinalNumber(cpf: string): FinalNumber {
	let sumB1 = 0;
	let sumB2 = 0;

	for (let i = 0; i < 9; i++) {
		const digit = Number(cpf[i]);
		sumB1 += digit * (i + 1);
		sumB2 += digit * (9 - i);
	}

	const B1 = (sumB1 % 11) % 10;
	const B2 = (sumB2 % 11) % 10;

	return { B1, B2 };
}
