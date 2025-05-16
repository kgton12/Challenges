export function newAvg(arr: number[], newavg: number): number {
	const currentSum = arr.reduce((sum, value) => sum + value, 0);
	const requiredTotal = newavg * (arr.length + 1);

	if (currentSum >= requiredTotal) throw new Error("Expected New Average is too low");

	return Math.ceil(requiredTotal - currentSum);
}
