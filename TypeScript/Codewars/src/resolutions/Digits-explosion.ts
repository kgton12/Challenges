export function explode(s: string): string {
	return Array.from(s)
		.map((value) => value.repeat(Number(value)))
		.join("");
}
