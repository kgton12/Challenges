export function disariumNumber(n: number): string {
	const result = String(n)
		.split("")
		.map(Number)
		.reduce((sum, num, index) => sum + num ** (index + 1), 0);

	return n === result ? "Disarium !!" : "Not !!";
}

console.log(disariumNumber(564));
