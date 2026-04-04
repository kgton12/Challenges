export function xo(str: string): boolean {
	const quantityX = str
		.toLowerCase()
		.split("")
		.filter((value) => value === "x").length;

	const quantityO = str
		.toLowerCase()
		.split("")
		.filter((value) => value === "o").length;

	return quantityX === quantityO;
}
