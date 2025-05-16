export function rentalCarCost(d: number): number {
	let discount = 0;
	const dailyValue = 40;

	if (d >= 3 && d < 7) discount = 20;
	if (d >= 7) discount = 50;

	return d * dailyValue - discount;
}
