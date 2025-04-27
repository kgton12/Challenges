export const strongNumber = (num: number): string => {
	const result = Array.from(num.toString())
		.map(Number)
		.reduce((prev, curr) => {
			return prev + factorial(curr);
		}, 0);

	return result === num ? "STRONG!!!!" : "Not Strong !!";
};

function factorial(n: number) {
	return n <= 1 ? 1 : n * factorial(n - 1);
}
