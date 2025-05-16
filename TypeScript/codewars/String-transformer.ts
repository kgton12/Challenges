export function stringTransformer(str: string): string {
	return str
		.split(" ")
		.reverse()
		.map((word) => [...word].map((char) => (char === char.toUpperCase() ? char.toLowerCase() : char.toUpperCase())).join(""))
		.join(" ");
}
