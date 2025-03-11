export function wave(str: string): Array<string> {
	const output: string[] = [];

	for (let index = 0; index < str.length; index++) {
		const word = str.split("");

		if (str[index].toUpperCase() !== " ") {
			word[index] = str[index].toUpperCase();

			output.push(word.join(""));
		}
	}

	return output;
}


