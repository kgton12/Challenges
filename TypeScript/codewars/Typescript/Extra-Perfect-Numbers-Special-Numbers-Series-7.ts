export function extraPerfect(n: number) {
	const result: number[] = [];

	for (let index = 1; index <= n; index += 2) {
		result.push(index);
	}

	return result;
}
