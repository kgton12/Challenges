export function duplicateEncode(word: string): string {
	const output: string[] = [];

	const arrayWord = word.split("");

	for (const element of arrayWord) {
		const character = arrayWord.filter((value) => value.toLowerCase() === element.toLowerCase()).length === 1 ? "(" : ")";

		output.push(character);
	}

	return output.join("");
}
