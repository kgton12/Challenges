export function balancedNum(number: number): string {
	const arrayValues = String(number).split("").map(Number);
	const length = arrayValues.length;

	if (length <= 2) return "Balanced";

	const halfLength = Math.floor(length / 2);
	const isEven = length % 2 === 0;

	const sumLeft = arrayValues.slice(0, halfLength - (isEven ? 1 : 0)).reduce((a, b) => a + b, 0);
	const sumRight = arrayValues.slice(halfLength + 1).reduce((a, b) => a + b, 0);

	return sumLeft === sumRight ? "Balanced" : "Not Balanced";
}
