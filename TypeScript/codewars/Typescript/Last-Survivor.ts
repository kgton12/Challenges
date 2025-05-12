export function lastSurvivor(letters: string, coords: number[]): string {
	const arrayLetters = letters.split("");

	for (const value of coords) {
		arrayLetters.splice(value, 1);
	}

	return arrayLetters.join("");
}
