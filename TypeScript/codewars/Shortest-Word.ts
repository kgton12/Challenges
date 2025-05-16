export function findShort(s: string): number {
	return s.split(" ").reduce((prev, curr) => {
		return curr.length < prev ? curr.length : prev;
	}, Number.POSITIVE_INFINITY);
}

console.log(findShort("Let's travel abroad shall we"));
