export function findMultiples(integer: number, limit: number): number[] {
	const loop = Math.floor(limit / integer);
	const result: number[] = [];

	for (let index = 1; index <= loop; index++) {
		result.push(index * integer);
	}

	return result;
}
