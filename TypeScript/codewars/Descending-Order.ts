export function descendingOrder(n: number): number {
	return Number(
		n
			.toString()
			.split("")
			.sort((a, b) => b.localeCompare(a))
			.join(""),
	);
}
