export function past(h: number, m: number, s: number): number {
	const hoursForMilliseconds = h * 60 * 60 * 1000;

	const minuteForMilliseconds = m * 60 * 1000;

	const secondsForMilliseconds = s * 1000;

	return hoursForMilliseconds + minuteForMilliseconds + secondsForMilliseconds;
}

console.log(past(0, 1, 1));
