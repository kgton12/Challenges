export function solve(s: string): string {
	const quantityLowerCase = Array.from(s).filter((value) => value === value.toLowerCase()).length;
	const quantityUpperCase = Array.from(s).filter((value) => value === value.toUpperCase()).length;

	return quantityUpperCase > quantityLowerCase ? s.toUpperCase() : s.toLowerCase();
}
