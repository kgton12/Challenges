export function jumpingNumber(n: number) {
	if (String(n).length === 1) return "Jumping!!";

	const result = String(n)
		.split("")
		.map(Number)
		.every((value, index, array) => {
			if (index === array.length - 1) return true;
			return Math.abs(value - array[index + 1]) === 1;
		});

	return result ? "Jumping!!" : "Not!!";
}
