export function predictAge(...ages: number[]): number {
	const result = ages.map((value) => value * value).reduce((sum, value) => sum + value, 0);

	return Math.trunc(Math.sqrt(result) / 2);
}
