import { EOL } from "node:os";

export function generateShape(int: number): string {
	const row = "+".repeat(int);

	return Array(int).fill(row).join(EOL);
}
