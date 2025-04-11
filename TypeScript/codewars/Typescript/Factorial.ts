export function factorial(n: number) {
	if (n <= 1) return 1;
	let sum = n;

	for (let index = n - 1; index >= 1; index--) {
		sum = index * sum;
	}
	return sum;
}


