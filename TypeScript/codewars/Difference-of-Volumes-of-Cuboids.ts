export function findDifference(a: [number, number, number], b: [number, number, number]): number {
	return Math.abs(a.reduce((x, y) => x * y) - b.reduce((x, y) => x * y));
}
