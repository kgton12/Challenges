export class Kata {
	highAndLow(numbers: string): string {
		const numbersArray = numbers.split(" ").map(Number);

		return `${Math.max(...numbersArray)} ${Math.min(...numbersArray)}`;
	}
}

const t = new Kata();

console.log(t.highAndLow("42"));
