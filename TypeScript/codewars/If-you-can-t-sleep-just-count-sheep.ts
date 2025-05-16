export function countSheep(num: number): string {
	const output: string[] = [];

	for (let index = 1; index <= num; index++) {
		output.push(`${index} sheep...`);
	}

	return output.join("");
}
