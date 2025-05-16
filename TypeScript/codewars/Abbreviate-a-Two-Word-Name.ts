export function abbrevName(name: string): string {
	return name
		.split(" ")
		.map((value) => value[0].toLocaleUpperCase())
		.join(".");
}
