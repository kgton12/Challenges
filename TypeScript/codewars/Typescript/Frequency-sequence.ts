export function freqSeq(str: string, sep: string): string {
	return [...str].map((char) => countCharacterOccurrences(str, char)).join(sep);
}

function countCharacterOccurrences(str: string, c: string): number {
	return [...str].filter((char) => char === c).length;
}


