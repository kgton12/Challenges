export function position(alphabet: string): string {
	const initialLetter = "a".charCodeAt(0);

	return `Position of alphabet: ${alphabet.charCodeAt(0) - initialLetter + 1}`;
}
