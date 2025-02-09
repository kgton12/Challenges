function map(arr: number[], fn: (n: number, i: number) => number): number[] {
	const numbersCollection: number[] = [];

	arr.map((value, index) => {
		numbersCollection.push(fn(value, index));
	});

	return numbersCollection;
}
