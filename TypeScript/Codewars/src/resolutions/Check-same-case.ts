export function sameCase(a: string, b: string): number {
	const [caseA, caseB] = [returnCase(a), returnCase(b)];

	if (caseA === caseB && ![caseA, caseB].includes(LetterCase.Other)) return 1;
	if (caseA !== caseB && ![caseA, caseB].includes(LetterCase.Other)) return 0;

	return -1;
}

const LetterCase = { Upper: 1, Lower: 2, Other: 3 };
type LetterCase = (typeof LetterCase)[keyof typeof LetterCase];

function returnCase(char: string): LetterCase {
	if (char.charCodeAt(0) >= 65 && char.charCodeAt(0) <= 90) return LetterCase.Upper;

	if (char.charCodeAt(0) >= 97 && char.charCodeAt(0) <= 122) return LetterCase.Lower;

	return LetterCase.Other;
}
