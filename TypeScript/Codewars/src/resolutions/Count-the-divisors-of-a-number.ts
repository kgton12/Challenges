export function divisors(n: number) {
	const half = Math.floor(n / 2);
	let result = 1;

	for (let index = 1; index <= half; index++) {
		if (Number.isInteger(n / index)) result++;
	}

	return result;
}
