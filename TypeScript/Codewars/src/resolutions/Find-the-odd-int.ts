export const findOdd = (xs: number[]): number => {
	const MapValues = new Map<number, number>();

	xs.map((value) => {
		MapValues.set(value, (MapValues.get(value) ?? 0) + 1);
	});

	const found = Array.from(MapValues).find((value) => value[1] % 2 !== 0);
	return found ? found[0] : xs[0];
};

//
