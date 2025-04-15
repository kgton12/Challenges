export function comp(a1: number[] | null, a2: number[] | null): boolean {
	if (!a1 || !a2) return false;
	if (a1.length !== a2.length) return false;

	const aSquared = a1.map((x) => x * x).sort((x, y) => x - y);
	const bSorted = a2.slice().sort((x, y) => x - y);

	return aSquared.every((val, index) => val === bSorted[index]);
}

const a = [121, 144, 19, 161, 19, 144, 19, 11];
const b = [121, 14641, 20736, 361, 25921, 361, 20736, 361];
console.log(comp(a, b));
