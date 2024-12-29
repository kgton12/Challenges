import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const inputs = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL,5).map(Number);
// const inputs = [-5, 0, -3, -4, 12];

let odd = 0;
let even = 0;
let negative = 0;
let positive = 0;

for (const input of inputs) {

	if (Math.abs(input % 2)  === 0 ) {
		even++;
	}

	if (Math.abs(input % 2)  === 1) {
		odd++;
	}

	if (input > 0) {
		positive++;
	} else if (input < 0) {
		negative++;
	}
}

console.log(
`${even} valor(es) par(es)
${odd} valor(es) impar(es)
${positive} valor(es) positivo(s)
${negative} valor(es) negativo(s)`);

// 3 valor(es) par(es)
// 2 valor(es) impar(es)
// 1 valor(es) positivo(s)
// 3 valor(es) negativo(s)
