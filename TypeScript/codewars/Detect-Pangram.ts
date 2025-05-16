export const isPangram = (phrase: string): boolean => {
	const regex = /[^a-zA-Z]/g;

	const setPhraseArray: Set<string> = new Set<string>(
		phrase
			.replace(regex, "")
			.split("")
			.map((value) => value.toLocaleLowerCase()),
	);

	return Array.from(setPhraseArray).length === 26;
};
