export function oddOrEven(array: number[]) {
	return array.reduce((prev, curr) => prev + curr, 0) % 2 === 0 ? "even" : "odd";
}
