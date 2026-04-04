export function potatoes(p0: number, w0: number, p1: number): number {
	const dryMatter = (w0 * (100 - p0)) / 100;
	const w1 = dryMatter / (1 - p1 / 100);
	return Math.floor(w1);
}
