export function multiplicationTable(size: number): number[][] {
	const output: number[][] = [];

	for (let i = 1; i <= size; i++) {
		const row: number[] = [];
		for (let j = 1; j <= size; j++) {
			row.push(i * j);
		}
		output.push(row);
	}

	return output;
}
