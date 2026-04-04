export function checkForFactor(base: number, factor: number) {
	return base % factor === 0;
}

console.log(checkForFactor(9, 2));
