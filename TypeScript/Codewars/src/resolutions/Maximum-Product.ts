export function adjacentElementsProduct(arr: number[]): number {
	let result = Number.MIN_SAFE_INTEGER;

	for (let index = 0; index < arr.length - 1; index++) {
		result = Math.max(result, arr[index] * arr[index + 1]);
	}

	return result;
}

console.log(adjacentElementsProduct([-23, 4, -5, 99, -27, 329, -2, 7, -921]));
