export function circleArea(radius: number): number {
	if (radius <= 0) throw new Error("");

	const area = Math.PI * radius * radius;
	return Math.round(area * 100) / 100;
}
