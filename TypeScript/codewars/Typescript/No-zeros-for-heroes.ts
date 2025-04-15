export function noBoringZeros(n: number): number {
	const sign = n < 0 ? -1 : 1;
	const noZeros = Number(
		Number(n.toString().replace("-", "").split("").reverse().join("")).toString().split("").reverse().join(""),
	);
	return noZeros * sign;
}

console.log(noBoringZeros(-1050));
