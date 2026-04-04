export function sumTwoSmallestNumbers(numbers: Array<number>): number {
	const [first, second] = numbers.sort((a, b) => a - b);

	return first + second;
}
