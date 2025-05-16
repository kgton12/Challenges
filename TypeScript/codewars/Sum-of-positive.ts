export function positiveSum(arr: number[]): number {
	return arr.filter((value) => value > 0).reduce((prev, value) => prev + value, 0);
}
