export function howMuchILoveYou(petals: number): string {
	const phrases: string[] = ["I love you", "a little", "a lot", "passionately", "madly", "not at all"];

	return phrases[(petals - 1) % 6];
}
