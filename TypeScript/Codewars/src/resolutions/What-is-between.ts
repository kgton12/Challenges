export function between(a: number, b: number): number[] {
	const result: number[] = [];

	for (let index = a; index <= b; index++) {
		result.push(index);
	}

	return result;
}
