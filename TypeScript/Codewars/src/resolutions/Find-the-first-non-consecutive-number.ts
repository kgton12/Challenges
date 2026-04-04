export function firstNonConsecutive(arr: number[]): null | number {
	for (let index = 0; index < arr.length; index++) {
		if (arr[index + 1] - arr[index] !== 1) return arr[index + 1];
	}

	return null;
}
