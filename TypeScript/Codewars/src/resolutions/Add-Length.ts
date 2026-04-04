export function addLength(str: string): string[] {
	return str.split(" ").map((value) => `${value} ${value.length}`);
}
