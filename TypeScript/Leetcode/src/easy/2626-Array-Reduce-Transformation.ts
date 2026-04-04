type Fn = (accumulator: number, current: number) => number;

function reduce(numbers: number[], fn: Fn, initial: number): number {
	return numbers.reduce((previous, current) => {
		return fn(previous, current);
	}, initial);
}
