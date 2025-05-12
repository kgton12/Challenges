export function wordValue(arr: string[]): number[] {
	return Array.from(arr).map((value, index) => {
		return processWord(value.replace(" ", "")) * index + 1;
	});
}

function processWord(word: string): number {
	const initialPosition = 96;

	return Array.from(word)
		.map((value) => value.charCodeAt(0) - initialPosition)
		.reduce((acc, value) => acc + value);
}

console.log(processWord("abc"));
