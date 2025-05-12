export function usdcny(usd: number): string {
	const conversionBase = 6.75;

	return `${(usd * conversionBase).toFixed(2)} Chinese Yuan`;
}
