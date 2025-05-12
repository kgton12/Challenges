function arrayDiff(a: number[], b: number[]): number[] {
	const bSet = new Set(b);

	return a.filter((value) => !bSet.has(value));
}
