export const otherAngle = (a: number, b: number): number => {
	const FULL_TRIANGLE = 180;

	return FULL_TRIANGLE - (a + b);
};
