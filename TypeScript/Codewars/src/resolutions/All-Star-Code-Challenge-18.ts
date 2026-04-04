export function strCount(str: string, letter: string): number {
	return [...str].filter((value) => value === letter).length;
}
