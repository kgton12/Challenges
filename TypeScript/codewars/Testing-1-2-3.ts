export function number(array: string[]): string[] {
	return array.map((value, index) => `${index + 1}: ${value}`);
}
