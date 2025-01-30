console.log(twoSum([2, 7, 11, 15], 9));

function twoSum(numberArray: number[], target: number): number[] {
	const result: number[] = [];
	const numMap = new Map<number, number>();

	for (let i = 0; i < numberArray.length; i++) {
		numMap.set(numberArray[i], i);
	}

	for (let index = 0; index < numberArray.length; index++) {
		const complement = target - numberArray[index];

		if (numMap.has(complement) && numMap.get(complement) !== index) {
			result.push(index);
			result.push(numMap.get(complement) ?? 0);
			break;
		}
	}
	return result;
}
