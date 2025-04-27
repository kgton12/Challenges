export const calc = (str: string): number => {
	const lettersFromAscii = Array.from(str).map((value) => String(value.charCodeAt(0)));
	const replaceSeven = lettersFromAscii.map((value) => value.replace(/7/g, "1"));

	const sumStr1 = lettersFromAscii.map(Number).reduce((acc, value) => acc + value, 0);
	const sumStr2 = replaceSeven.map(Number).reduce((acc, value) => acc + value, 0);

	return sumStr1 - sumStr2;
};
