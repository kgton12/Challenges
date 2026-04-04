export function powersOfTwo(n: number): number[] {
	const loop = new Array(n + 1).fill(0);

	return loop.map((_, index) => 2 ** index);
}

console.log(powersOfTwo(4));
