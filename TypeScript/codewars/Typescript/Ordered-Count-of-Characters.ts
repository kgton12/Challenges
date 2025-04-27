export function orderedCount(text: string): [string, number][] {
	const distinctLetters = Array.from(new Set(text));
	const resultList: [string, number][] = [];

	for (const char of distinctLetters) {
		const count = countLetter(text, char);
		resultList.push([char, count]);
	}

	return resultList;
}

function countLetter(str: string, char: string): number {
	return str.split(char).length - 1;
}
