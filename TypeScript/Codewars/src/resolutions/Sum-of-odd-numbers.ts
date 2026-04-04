export function rowSumOddNumbers(n: number): number {
	let primaryOdd = 1;
	let line: number[] = [];
	for (let i = 1; i <= n; i++) {
		line = [];

		for (let j = 0; j < i; j++) {
			line.push(primaryOdd);
			primaryOdd += 2;
		}
	}

	return line.reduce((prev, curr) => prev + curr, 0);
}
