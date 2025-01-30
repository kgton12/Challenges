function createCounter(n: number): () => number {
	let count = n;
	return function () {
		return count++;

	}
}


const counter = createCounter(10)


