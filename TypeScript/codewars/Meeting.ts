export function meeting(s: string): string {
	return s
		.toUpperCase()
		.split(";")
		.map((n) => `(${n.split(":").reverse().join(", ")})`)
		.sort()
		.join("");
}
