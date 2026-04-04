import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

for (const element of input) {
	if (element.trim() === "") break;

	const isValidPassword = validatePassword(element);

	console.log(isValidPassword ? "Senha valida." : "Senha invalida.");
}

function validatePassword(p: string): boolean {
	const hasUpperCase = /[A-Z]/.test(p);
	const hasLowerCase = /[a-z]/.test(p);
	const hasNumber = /[0-9]/.test(p);
	const hasNoSpecialChar = /^[a-zA-Z0-9]+$/.test(p);
	const correctSize = p.length >= 6 && p.length <= 32;

	return hasUpperCase && hasLowerCase && hasNumber && hasNoSpecialChar && correctSize;
}
