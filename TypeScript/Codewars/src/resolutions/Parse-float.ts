export function parseF(s: string): number | null {
	return Number.isNaN(Number.parseFloat(s)) ? null : Number.parseFloat(s);
}
