export function persistence(num: number): number {
	let steps = 0;
	let currentNumber = num.toString();

	while (currentNumber.length !== 1) {
		currentNumber = multiplyDigits(currentNumber);
		steps++;
	}

	return steps;
}

function multiplyDigits(numberStr: string): string {
	return numberStr
		.split("")
		.map(Number)
		.reduce((product, digit) => product * digit, 1)
		.toString();
}
