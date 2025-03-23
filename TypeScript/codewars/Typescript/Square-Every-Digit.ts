export class Kata {
	squareDigits(num: number): number {
		return Number(
			String(num)
				.split("")
				.reduce((prev, curr) => {
					return prev + (Number(curr) ** 2).toString();
				}, ""),
		);
	}
}
