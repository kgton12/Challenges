export function findAverage(array: number[]): number {
	if (array.length === 0) return 0;

	const avg = array.reduce((prev, curr) => prev + curr, 0) / array.length;

	return avg;
}
