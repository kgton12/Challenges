export function minSum(arr: number[]): number {
	const orderedArray = [...arr].sort((a, b) => a - b);
	const middleInArray = Math.floor(arr.length / 2);
	let sum = 0;

	for (let index = 0; index < middleInArray; index++) {
		sum += (orderedArray.shift() ?? 0) * (orderedArray.pop() ?? 0);
	}

	return sum;
}
