type Fn = (n: number, i: number) => boolean;

function filter(arr: number[], fn: Fn): number[] {
	return arr.filter((val, index) => {
		return fn(val, index);
	});
}
