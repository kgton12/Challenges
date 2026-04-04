export function checkExam(array1: string[], array2: string[]): number {
	let result = 0;

	for (let index = 0; index < array1.length; index++) {
		if (array2[index] === "") continue;
		if (array1[index] === array2[index]) result += 4;
		else result--;
	}

	return Math.max(result, 0);
}
