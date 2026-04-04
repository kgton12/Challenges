export function divCon(x: (string | number)[]): number {
	const { sumNumber, sumString } = x.reduce(
		(acc, element) => {
			if (typeof element === "string") acc.sumString += Number(element);
			else acc.sumNumber += element;
			return acc;
		},
		{ sumNumber: 0, sumString: 0 },
	);

	return sumNumber - sumString;
}
