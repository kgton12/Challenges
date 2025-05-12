export function maxGap(nums: number[]): number {
	const outputValues: number[] = [];

	nums
		.sort((a, b) => a - b)
		.forEach((value, index, array) => {
			if (index !== array.length - 1) outputValues.push(Math.abs(array[index + 1] - value));
		});

	return Math.max(...outputValues);
}

console.log(maxGap([-3, -27, -4, -2]));
