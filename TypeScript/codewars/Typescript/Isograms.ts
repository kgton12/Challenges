export function isIsogram(str: string): boolean {
	return new Set<string>([...str.toLowerCase()]).size === str.length;
}
