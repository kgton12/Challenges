export function sumPairs(ints: number[], s: number): [number, number] | undefined {
	const seen = new Set<number>();

	for (const num of ints) {
		const complement = s - num;
		if (seen.has(complement)) {
			return [complement, num];
		}
		seen.add(num);
	}
}
