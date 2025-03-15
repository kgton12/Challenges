export function squareSum(numbers: number[]): number {
	return numbers.reduce((prev, curr) => prev + curr ** 2, 0);
}
