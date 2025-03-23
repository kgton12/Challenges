export function litres(time: number): number {
	const litrePerHour = 0.5;
	return Math.floor(litrePerHour * time);
}
