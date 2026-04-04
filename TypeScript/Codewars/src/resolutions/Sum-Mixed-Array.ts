export function sumMix(x: (number | string)[]): number {
	return x.map(Number).reduce((prev, curr) => prev + curr);
}
