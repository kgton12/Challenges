export function toAlternatingCase(s: string): string {
	return [...s]
		.map((value) => {
			return value === value.toLowerCase() ? value.toUpperCase() : value.toLowerCase();
		})
		.join("");
}
