export const summation = (num: number) => {
	let sum = 0;

	for (let index = 0; index <= num; index++) {
		sum += index;
	}

	return sum;
};
