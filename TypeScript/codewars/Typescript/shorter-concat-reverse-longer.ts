export function shorterReverseLonger(a: string, b: string): string {
	const [shorter, longer] = a.length >= b.length ? [b, a] : [a, b];

	const reversedLonger = [...longer].reverse().join("");

	return `${shorter}${reversedLonger}${shorter}`;
}
