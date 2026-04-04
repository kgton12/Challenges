export function countPositivesSumNegatives(input: number[] | null | undefined) {
	if (input === null || input === undefined || input.length <= 0) return [];

	const countPositiveNumbers = input?.filter((value: number) => value > 0).length;

	const sumNegativeNumbers = input?.filter((value: number) => value < 0).reduce((prev: number, curr: number) => prev + curr, 0);

	return [countPositiveNumbers, sumNegativeNumbers];
}
