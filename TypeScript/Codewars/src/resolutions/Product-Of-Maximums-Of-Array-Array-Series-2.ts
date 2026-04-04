export function maxProduct(numbers: number[], size: number): number {
	return numbers
		.sort((a, b) => a - b)
		.slice(-size)
		.reduce((sum, value) => sum * value, 1);
}
