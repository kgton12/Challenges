export const fakeBin = (x: string): string => {
	return [...x].map((value) => (Number(value) < 5 ? "0" : "1")).join("");
};
