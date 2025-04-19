export function accum(s: string): string {
	return s
		.split("")
		.map((value, index) => `${value.toUpperCase()}${value.toLowerCase().repeat(index)}`)
		.join("-");
}
