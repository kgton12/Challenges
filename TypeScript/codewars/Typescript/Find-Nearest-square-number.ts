export function nearestSq(n: number): number {
	const squareRoot = Math.sqrt(n);

	if (Number.isInteger(squareRoot)) return n;

	const smallest = Math.floor(squareRoot) ** 2;

	const biggest = Math.ceil(squareRoot) ** 2;

	return nearestToX([smallest, biggest], n);
}

function nearestToX(values: number[], x: number): number {
	return values.reduce((prev, curr) => (Math.abs(curr - x) < Math.abs(prev - x) ? curr : prev));
}
