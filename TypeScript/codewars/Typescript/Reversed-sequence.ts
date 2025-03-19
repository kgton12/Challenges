export const reverseSeq = (n: number): number[] => {
	const output: number[] = [];

	for (let index = n; index >= 1; index--) {
		output.push(index);
	}

	return output;
};

console.log(reverseSeq(5));
