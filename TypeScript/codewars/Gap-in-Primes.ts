export const gap = (gap: number, startSearch: number, endSearch: number): number[] | null => {
	const output: number[] = [];

	for (let index = startSearch; index <= endSearch; index++) {
		const numberWithGap = index + gap;
		let isValidNumber = true;

		if (isPrimeNumber(index) && isPrimeNumber(numberWithGap) && numberWithGap <= endSearch) {
			for (let j = index + 1; j < numberWithGap; j++) {
				if (isPrimeNumber(j)) {
					isValidNumber = false;
					break;
				}
			}
			if (isValidNumber) output.push(index, numberWithGap);
		}
	}

	return output.length <= 0 ? null : output.slice(0, 2);
};

function isPrimeNumber(n: number): boolean {
	if (n < 2) return false;

	const square = Math.trunc(Math.sqrt(n));

	for (let index = 2; index <= square; index++) {
		if (n % index === 0) return false;
	}

	return true;
}
