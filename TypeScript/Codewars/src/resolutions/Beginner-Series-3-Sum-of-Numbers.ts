export function getSum(a: number, b: number): number {
	const min = Math.min(a, b);
	const max = Math.max(a, b);
	let sum = 0;

	for (let index = min; index <= max; index++) {
		sum += index;
	}

	return sum;
}

console.log(getSum(-1, 2));
