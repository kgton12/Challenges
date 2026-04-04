export function tidyNumber(num: number): boolean {
	return String(num)
		.split("")
		.map(Number)
		.every((value, index, array) => {
			if (index === array.length - 1) return true;

			return value <= array[index + 1];
		});
}
