export class Kata {
	disemvowel(str: string): string {
		const vowel = ["a", "e", "i", "o", "u"];
		const newWord: string[] = [];
		str.split("").map((value) => {
			if (!vowel.includes(value.toLocaleLowerCase())) newWord.push(value);
		});

		return newWord.join("");
	}
}
