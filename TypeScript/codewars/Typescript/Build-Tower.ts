export const towerBuilder = (nFloors: number): string[] => {
	const Space = " ";
	const Asterisk = "*";
	const output: string[] = [];
	let quantityAsterisk = 1;

	for (let index = 1; index <= nFloors; index++) {
		const blankSpace = nFloors - index;

		const line = Space.repeat(blankSpace) + Asterisk.repeat(quantityAsterisk) + Space.repeat(blankSpace);

		output.push(line);

		quantityAsterisk += 2;
	}

	return output;
};
