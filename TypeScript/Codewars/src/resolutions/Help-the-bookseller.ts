export const stockList = (listOfArt: string[], listOfCat: string[]): string => {
	if (listOfArt.length === 0 || listOfCat.length === 0) {
		return "";
	}

	const output: string[] = [];

	for (const cat of listOfCat) {
		let sum = 0;

		for (const art of listOfArt) {
			const [stockListWord, value] = art.split(" ");

			if (stockListWord.startsWith(cat)) sum += Number(value);
		}

		output.push(`(${cat} : ${sum})`);
	}

	return output.join(" - ");
};
