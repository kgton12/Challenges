export function quarterOf(month: number): number {
	const MONTHS_IN_A_QUARTER = 3;

	return Math.ceil(month / MONTHS_IN_A_QUARTER);
}
