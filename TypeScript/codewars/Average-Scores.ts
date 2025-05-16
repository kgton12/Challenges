export function average(scores: number[]): number {
	return Math.round(scores.reduce((sum, value) => sum + value, 0) / scores.length);
}
