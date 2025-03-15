export class Kata {
	getCount(str: string): number {
		const vowelsList = ["a", "e", "i", "o", "u"];
		let count = 0;

		for (const element of str) {
			if (vowelsList.includes(element)) count++;
		}

		return count;
	}
}
