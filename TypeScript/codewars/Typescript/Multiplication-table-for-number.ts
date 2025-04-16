export function multiTable(number: number): string {
	const result: string[] = [];

	for (let index = 1; index <= 10; index++) {
		result.push(`${index} * ${number} = ${index * number}`);
	}

	return result.join("\n");
}
