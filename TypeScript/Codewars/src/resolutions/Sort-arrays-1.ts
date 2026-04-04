export function sortMe(names: string[]): string[] {
	return names.sort((a, b) => a.localeCompare(b));
}
