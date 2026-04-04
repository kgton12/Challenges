export function areYouPlayingBanjo(name: string): string {
	const letter = "r";

	return name[0].toLowerCase().includes(letter) ? `${name} plays banjo` : `${name} does not play banjo`;
}
