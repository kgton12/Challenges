export function specialNumber(n: number) {
	const result = String(n)
		.split("")
		.map(Number)
		.every((value) => value <= 5);

	return result ? "Special!!" : "NOT!!";
}
