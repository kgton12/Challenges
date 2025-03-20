export function sumArray(array: number[] | null): number {
	if (array === null || array.length === 1) return 0;

	const orderedArray = array.sort((a, b) => a - b);

	orderedArray.shift();
	orderedArray.pop();

	return orderedArray.reduce((prev, curr) => prev + curr, 0);
}
