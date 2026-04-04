export function openOrSenior(data: number[][]): string[] {
	const output: string[] = [];

	for (const element of data) {
		element[0] >= 55 && element[1] >= 7 ? output.push("Senior") : output.push("Open");
	}

	return output;
}
