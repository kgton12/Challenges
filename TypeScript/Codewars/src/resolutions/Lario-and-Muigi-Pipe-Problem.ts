export function pipeFix(numbers: number[]): number[] {
	const initialSequence = numbers[0];
	const finalSequence = numbers[numbers.length - 1] ?? initialSequence;
	const result: number[] = [];

	for (let index = initialSequence; index <= finalSequence; index++) {
		result.push(index);
	}
	return result;
}
