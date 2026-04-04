const TypeYears = {
	Cat: 1,
	Dog: 2,
};

export function humanYearsCatYearsDogYears(humanYears: number): [number, number, number] {
	const catYears = calculateYears(humanYears, TypeYears.Cat);
	const dogYears = calculateYears(humanYears, TypeYears.Dog);

	return [humanYears, catYears, dogYears];
}

function calculateYears(years: number, Tp: number): number {
	const yearsMultiplications = Tp === TypeYears.Cat ? 4 : 5;
	const array: number[] = [];

	array.push(...[15, 9], ...new Array(years).fill(yearsMultiplications));

	return array.slice(0, years).reduce((prev, curr) => prev + curr, 0);
}

console.log(humanYearsCatYearsDogYears(3));
