export function grow(arr: number[]): number {
	return arr.reduce((prev, curr) => prev * curr);
}
