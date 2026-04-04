export function cockroachSpeed(s: number): number {
	const secondsInOneHour = 3600;

	const centimetersInOneKilometers = 100000;

	return Math.floor((s * centimetersInOneKilometers) / secondsInOneHour);
}
