export function arrayLeaders(numbers: number[]): number[] {
	const resultArray: number[] = [];

	for (let index = 0; index < numbers.length; index++) {
		const totalRemaining = numbers.slice(index + 1).reduce((sum, value) => sum + value, 0);

		if (numbers[index] > totalRemaining) resultArray.push(numbers[index]);
	}

	return resultArray;
}
