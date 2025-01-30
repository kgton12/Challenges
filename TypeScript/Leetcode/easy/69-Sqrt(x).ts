console.log(mySqrt(8));

function mySqrt(N: number): number {
	if (N === 0) return 0;

	const iterations = 100;
	const result = 0;
	let X = N;

	const num = X;
	for (let i = 0; i < iterations; i++) {
		X = 0.5 * (X + num / X);
	}
	return Math.floor(X);
}
