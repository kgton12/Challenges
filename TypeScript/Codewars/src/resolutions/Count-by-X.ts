export function countBy(x: number, n: number): number[] {
	const output: number[] = [];
	for (let index = 1; index <= n; index++) {
		output.push(index * x);
	}
	return output;
}
