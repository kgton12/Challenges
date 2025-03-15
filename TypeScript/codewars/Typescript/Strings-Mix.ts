type IMix = {
	letter: string;
	quantity: number;
	local: string;
};

const Local = {
	S1: "1",
	S2: "2",
	Equal: "=",
};

export const mix = (s1: string, s2: string): string => {
	const output: IMix[] = [];

	const Regex = /[^a-z]/g;
	const arraySumLetters = new Set<string>([...s1.replace(Regex, "").split(""), ...s2.replace(Regex, "").split("")]);

	Array.from(arraySumLetters).map((letter) => {
		const response: IMix = { letter: "", local: "", quantity: 0 };

		const countS1 = countLetter(s1, letter);
		const countS2 = countLetter(s2, letter);

		if (countS1 > countS2) {
			response.quantity = countS1;
			response.local = Local.S1;
		} else if (countS2 > countS1) {
			response.quantity = countS2;
			response.local = Local.S2;
		} else {
			response.quantity = countS1;
			response.local = Local.Equal;
		}

		response.letter = letter;

		output.push(response);
	});

	return output
		.filter((value) => value.quantity > 1)
		.sort((a, b) => sortMix(a, b))
		.map((value) => `${value.local}:${value.letter.repeat(value.quantity)}`)
		.join("/");
};

function countLetter(arr: string, letter: string): number {
	return arr.split("").filter((value) => value === letter).length;
}

function sortMix(a: IMix, b: IMix): number {
	if (a.quantity !== b.quantity) return b.quantity - a.quantity;

	const order: Record<string, number> = { "1": 0, "2": 1, "=": 2 };
	if (order[a.local] !== order[b.local]) {
		return order[a.local] - order[b.local];
	}

	return a.letter.localeCompare(b.letter);
}
