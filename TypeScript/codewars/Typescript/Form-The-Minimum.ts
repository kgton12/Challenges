export const minValue = (values: number[]): number => {
	return Number([...new Set(values)].sort((a, b) => a - b).join(""));
};

console.log(minValue([1, 3, 1]));
