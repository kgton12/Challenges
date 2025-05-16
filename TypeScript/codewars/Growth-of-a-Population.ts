export const nbYear = (p0: number, percent: number, aug: number, p: number): number => {
	let years = 0;
	let newPopulation = p0;

	while (newPopulation < p) {
		years++;
		newPopulation = calculatePopulation(newPopulation, percent, aug);
	}

	return years;
};

function calculatePopulation(p0: number, percent: number, aug: number) {
	return Math.floor(p0 + (p0 * percent) / 100 + aug);
}
