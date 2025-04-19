export const encryptThis = (str: string): string => {
	if (!str.trim()) return "";

	return str
		.split(" ")
		.map((word) => {
			if (word.length === 0) return "";

			const firstLetterAscii = word[0].charCodeAt(0);
			if (word.length === 1) return firstLetterAscii.toString();
			if (word.length === 2) return firstLetterAscii + word[1];

			const middlePart = word.slice(2, word.length - 1);
			return firstLetterAscii + word[word.length - 1] + middlePart + word[1];
		})
		.join(" ");
};
