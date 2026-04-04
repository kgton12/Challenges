console.log(searchInsert([1, 3, 5, 6], 2));

function searchInsert(numberArray: number[], target: number): number {
	let targetIndex = numberArray.indexOf(target);

	if (targetIndex === -1) {
		for (let index = 0; index < numberArray.length; index++) {
			if (numberArray[index] > target) {
				targetIndex = index;
				break;
			}
		}

		if (targetIndex === -1) targetIndex = numberArray.length;
	}

	return targetIndex;
}
