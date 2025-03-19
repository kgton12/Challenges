export function isValidWalk(walk: string[]): boolean {
	if (walk.length !== 10) return false;

	let n = 0;
	let s = 0;
	let e = 0;
	let w = 0;

	for (const direction of walk) {
		if (direction === "n") n++;
		if (direction === "s") s++;
		if (direction === "e") e++;
		if (direction === "w") w++;
	}

	return n === s && e === w;
}
