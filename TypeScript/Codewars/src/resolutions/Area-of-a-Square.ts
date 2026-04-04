export function squareArea(num: number): number {
	const r = (2 * num) / Math.PI;
	const area = r * r;
	return Math.round(area * 100) / 100;
}
