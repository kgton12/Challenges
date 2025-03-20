export function betterThanAverage(classPoints: number[], yourPoints: number): boolean {
	const avgClass = classPoints.reduce((prev, curr) => prev + curr, 0) / classPoints.length;

	return yourPoints > avgClass;
}
