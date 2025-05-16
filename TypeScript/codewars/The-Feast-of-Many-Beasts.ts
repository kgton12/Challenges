export function feast(beast: string, dish: string): boolean {
	return getFirstAndLastLetter(beast) === getFirstAndLastLetter(dish);
}

function getFirstAndLastLetter(str: string): string {
	const firstLetter = str.charAt(0);
	const lastLetter = str.charAt(str.length - 1);

	return `${firstLetter}${lastLetter}`;
}
