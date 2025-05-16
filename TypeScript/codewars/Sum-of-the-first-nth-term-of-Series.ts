export function SeriesSum(n: number): string {
	let sum = 1;
	let term = 1;

	if (n <= 0) return (0).toFixed(2);

	for (let index = 1; index < n; index++) {
		term = term + 3;
		sum += 1 / term;
	}
	return sum.toFixed(2);
}

console.log(SeriesSum(1));
