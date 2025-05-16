export function findUniq(arr: number[]): number {
	const output = new Map<number, number>();

	for (const element of arr) {
		output.set(element, (output.get(element) || 0) + 1);
	}

	return Array.from(output)
		.filter((value) => value[1] === 1)
		.map((value) => value[0])[0];
}

console.log(findUniq([1, 1, 1, 2, 1, 1]));
