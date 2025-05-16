export function sumDigits(n: number): number {
	return String(Math.abs(n))
		.split("")
		.map(Number)
		.reduce((prev, curr) => curr + prev, 0);
}
