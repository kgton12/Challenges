export const centuryFromYear = (year: number): number => {
	const oneCentury = 100;
	return Math.ceil(year / oneCentury);
};
