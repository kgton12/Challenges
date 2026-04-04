export class Kata {
	findLongest(array: number[]): number {
		return array.reduce((longest, current) => (current.toString().length > longest.toString().length ? current : longest), 0);
	}
}
