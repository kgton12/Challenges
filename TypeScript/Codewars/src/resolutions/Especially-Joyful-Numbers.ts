export const numberJoy = (n: number): boolean => {
	const sum = n
		.toString()
		.split("")
		.reduce((sum, value) => sum + Number(value), 0);

	const reverse = Number(sum.toString().split("").reverse().join(""));

	console.log(reverse, sum);

	return n === reverse * sum;
};
