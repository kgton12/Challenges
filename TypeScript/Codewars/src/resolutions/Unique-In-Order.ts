export function uniqueInOrder(iterable: string | (string | number)[]): (string | number)[] {
	let actualElement: string | number = "";

	const result: (string | number)[] = [];

	for (const element of iterable) {
		if (element !== actualElement) {
			result.push(element);
			actualElement = element;
		}
	}

	return result;
}
