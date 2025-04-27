export function evaporator(content: number, evapPerDay: number, threshold: number): number {
	let quantityOfDays = 0;
	let vapor = content;
	const percentThreshold = (content * threshold) / 100;

	while (vapor > percentThreshold) {
		vapor = vapor - (vapor * evapPerDay) / 100;

		quantityOfDays++;
	}

	return quantityOfDays;
}
