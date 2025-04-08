export function findEvenIndex(arr: number[]): number {
	for (let index = 0; index < arr.length; index++) {
		if (calculateArrayElements(arr, index)) return index;
	}

	return -1;
}

function calculateArrayElements(arr: number[], index: number): boolean {
	const initialPart = arr.slice(0, index).reduce((prev, curr) => prev + curr, 0);

	const finalPart = arr.slice(index + 1).reduce((prev, curr) => prev + curr, 0);

	return initialPart === finalPart;
}
