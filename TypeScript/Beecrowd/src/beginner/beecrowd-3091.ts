import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { join } from "node:path";
import { stdin } from "node:process";

function readFileInput(): string {
	if (process.env.NODE_ENV === "TEST") {
		return readFileSync(join(process.cwd(), "file.txt"), "utf-8");
	}
	return readFileSync(stdin.fd, { encoding: "utf8" });
}

const inputData = readFileInput().split(EOL).map(Number);

const A = inputData[0];
const B = inputData[1];

console.log(A % B);
//
