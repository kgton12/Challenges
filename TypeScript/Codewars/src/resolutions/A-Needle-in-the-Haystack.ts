// biome-ignore lint/suspicious/noExplicitAny: <explanation>
export function findNeedle(haystack: any[]): string {
	const index = haystack.map(String).findIndex((value) => value === "needle");

	return `found the needle at position ${index}`;
}
