export function stairsIn20(stairs: number[][]) {
	let sum = 0;
	const YEARS = 20;

	for (const element of stairs) {
		sum += element.reduce((prev, curr) => prev + curr);
	}

	return sum * YEARS;
}
