export function number(busStops: [number, number][]): number {
	const passagesFlow = {
		entered: 0,
		left: 0,
	};

	busStops.map((value) => {
		passagesFlow.entered += value[0];
		passagesFlow.left += value[1];
	});

	return passagesFlow.entered - passagesFlow.left;
}
