export function evenNumbers(array: number[], n: number): number[] {
	return array.filter((value) => value % 2 === 0).slice(n * -1);
}
