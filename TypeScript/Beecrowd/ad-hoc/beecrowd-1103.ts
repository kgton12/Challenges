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
	const [H1, M1, H2, M2] = element.split(" ");

	if (
		(H1.trim() === "0" && H2.trim() === "0" && M1.trim() === "0" && M2.trim() === "0") ||
		H1 === undefined ||
		M1 === undefined ||
		H2 === undefined ||
		M2 === undefined
	)
		break;

	console.log(differenceBetweenTime(H1, M1, H2, M2));
}

function differenceBetweenTime(H1: string, M1: string, H2: string, M2: string): number {
	let day = 1;

	const startHour = H1.trim().padStart(2, "0");
	const endHour = H2.trim().padStart(2, "0");
	const startMinutes = M1.trim().padStart(2, "0");
	const endMinutes = M2.trim().padStart(2, "0");

	const startTime = new Date(`2025-01-${day.toString().padStart(2, "0")}T${startHour}:${startMinutes}:00`);

	if (
		startHour > endHour ||
		(startHour === endHour && startMinutes > endMinutes) ||
		(startHour === endHour && startMinutes === endMinutes)
	) {
		day++;
	}

	const endTime = new Date(`2025-01-${day.toString().padStart(2, "0")}T${endHour}:${endMinutes}:00`);

	const differenceInMilliseconds = endTime.getTime() - startTime.getTime();

	const differenceInMinutes = differenceInMilliseconds / (1000 * 60);

	return differenceInMinutes;
}
