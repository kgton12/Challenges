export function vaporcode(str: string): string {
	return str.replaceAll(" ", "").toUpperCase().split("").join("  ");
}
