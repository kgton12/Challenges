export function tribonacci([a, b, c]: [number, number, number], n: number): number[] {
	const output = [a, b, c];

	output.push(a + b + c);

	for (let index = 3; index < n - 1; index++) {
		const value = output[index] + output[index - 1] + output[index - 2];
		output.push(value);
	}

	return output.slice(0, n);
}

console.log(tribonacci([1, 1, 1], 1));
