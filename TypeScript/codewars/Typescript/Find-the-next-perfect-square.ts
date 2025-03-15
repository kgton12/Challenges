export function findNextSquare(sq: number): number {
	const squareRoot = Math.sqrt(sq);

	const isPerfectSquareRoot = squareRoot === Number.parseInt(squareRoot.toString());

	return isPerfectSquareRoot ? (squareRoot + 1) ** 2 : -1;
}
