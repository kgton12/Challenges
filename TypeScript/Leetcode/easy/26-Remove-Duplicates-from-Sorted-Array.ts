function removeDuplicates(inputNumbers: number[]): number {
	let itemIndex = 0;
	for (let i = 1; i < inputNumbers.length; i++) {
		if (inputNumbers[i] !== inputNumbers[itemIndex]) {
			itemIndex++;
			inputNumbers[itemIndex] = inputNumbers[i];
		}
	}
	return ++itemIndex;
}
