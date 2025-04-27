function mxdiflg(a1: string[], a2: string[]): number {
	if (a1.length === 0 || a2.length === 0) return -1;

	const a1Lengths = a1.map((s) => s.length);
	const a2Lengths = a2.map((s) => s.length);

	const maxA1 = Math.max(...a1Lengths);
	const minA1 = Math.min(...a1Lengths);
	const maxA2 = Math.max(...a2Lengths);
	const minA2 = Math.min(...a2Lengths);

	return Math.max(Math.abs(maxA1 - minA2), Math.abs(maxA2 - minA1));
}

console.log(
	mxdiflg(["ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh"], ["bbbaaayddqbbrrrv"]),
);
