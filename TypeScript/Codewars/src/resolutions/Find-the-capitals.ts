export function capitals(word: string): number[] {
	const result: number[] = [];

	[...word].forEach((value, index) => {
		if (value === value.toLocaleUpperCase()) result.push(index);
	});

	return result;
}

console.log(capitals("AAA"));
