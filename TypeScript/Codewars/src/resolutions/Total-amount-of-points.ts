export function points(games: string[]): number {
	return games.reduce((prev, curr) => {
		const [x, y] = curr.split(":");

		if (x > y) return prev + 3;

		if (y === x) return prev + 1;

		return prev;
	}, 0);
}
