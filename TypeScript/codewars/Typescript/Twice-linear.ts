export function dblLinear(n: number): number {
	const u: number[] = new Array(n + 1);
	u[0] = 1;

	let i = 0;
	let j = 0;

	for (let k = 1; k <= n; k++) {
		const nextCandidate1 = 2 * u[i] + 1;
		const nextCandidate2 = 3 * u[j] + 1;
		const nextVal = Math.min(nextCandidate1, nextCandidate2);
		u[k] = nextVal;
		if (nextVal === nextCandidate1) i++;
		if (nextVal === nextCandidate2) j++;
	}

	return u[n];
}

console.log(dblLinear(10));
