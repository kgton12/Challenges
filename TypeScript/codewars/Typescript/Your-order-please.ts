console.log(order("is2 Thi1s T4est 3a"));

export function order(words: string): string {
	type OrderByNumber = {
		word: string;
		n: number;
	};

	if (words.trim() === "") return "";
	const stringsArray: OrderByNumber[] = [];
	const regex = /[0-9]/;

	words.split(" ").map((value) => {
		const n = value.match(regex)?.map(Number)[0] ?? 0;

		stringsArray.push({ word: value, n });
	});

	return stringsArray
		.sort((a, b) => a.n - b.n)
		.map((value) => value.word)
		.join(" ");
}
