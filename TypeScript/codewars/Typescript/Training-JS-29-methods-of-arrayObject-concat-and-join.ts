export function bigToSmall(arr: number[][]): string {
	return arr
		.flat()
		.sort((a, b) => b - a)
		.join(">");
}
