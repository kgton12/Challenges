export const check = (a: (number | string)[], x: number | string): boolean => {
	return a.findIndex((value) => value === x) !== -1;
};

console.log(check([66, 101], 66));
//
