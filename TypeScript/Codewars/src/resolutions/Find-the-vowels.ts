export function vowelIndices(word: string): number[] {
	const result: number[] = [];
	const vowels = new Set(["a", "e", "i", "o", "u", "y"]);

	for (let index = 0; index < word.length; index++) {
		const char = word[index].toLowerCase();
		if (vowels.has(char)) {
			result.push(index + 1);
		}
	}

	return result;
}
