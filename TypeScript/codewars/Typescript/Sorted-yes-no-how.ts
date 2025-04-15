export function isSortedAndHow(array: number[]): string {
	const ASCENDING = "yes, ascending";
	const DESCENDING = "yes, descending";
	const NO = "no";

	const originalArray = array;
	const arrayAscending = [...array].sort((a, b) => a - b);
	const arrayDescending = [...array].sort((a, b) => b - a);

	switch (true) {
		case compareNumberArrays(originalArray, arrayAscending):
			return ASCENDING;
		case compareNumberArrays(originalArray, arrayDescending):
			return DESCENDING;

		default:
			return NO;
	}
}

function compareNumberArrays(arr1: number[], arr2: number[]): boolean {
	return arr1.every((value, index) => value === arr2[index]);
}

console.log(isSortedAndHow([15, 7, 3, -8]));
