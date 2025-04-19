export function solve(s: string): number {
	let currentSum = 0;
	const sums: number[] = [];
	const vowelsRegex = /[aeiou]/;

	for (const char of s.toLowerCase()) {
		if (vowelsRegex.test(char)) {
			if (currentSum > 0) sums.push(currentSum);
			currentSum = 0;
		} else {
			currentSum += calculateAlphabetPosition(char);
		}
	}

	if (currentSum > 0) sums.push(currentSum);

	return sums.length > 0 ? Math.max(...sums) : 0;
}

function calculateAlphabetPosition(char: string): number {
	const asciiValueForA = 97;
	return char.charCodeAt(0) - asciiValueForA + 1;
}
