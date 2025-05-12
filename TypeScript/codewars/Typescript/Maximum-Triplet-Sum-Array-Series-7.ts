export function maxTriSum(nums: number[]): number {
	return Array.from(new Set(nums))
		.sort((a, b) => a - b)
		.slice(-3)
		.reduce((sum, value) => sum + value, 0);
}
