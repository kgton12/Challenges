export function duplicateCount(text: string): number {
	const output: string[] = [];

	const arrayValue = text.split("").map((value) => value.toLocaleLowerCase());

	arrayValue.map((value, index) => {
		if (arrayValue.indexOf(value) !== index) output.push(value);
	});

	const result = Array.from(new Set([...output]));

	return result.length;
}
