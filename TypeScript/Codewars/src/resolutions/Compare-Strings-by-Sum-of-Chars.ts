export function compare(s1: string | null, s2: string | null): boolean {
	const sumS1 = sumAsciiCode(s1);
	const sumS2 = sumAsciiCode(s2);

	return sumS1 === sumS2;
}

function sumAsciiCode(str: string | null): number {
	if (!str || /[^a-zA-Z]/.test(str)) return 0;

	// const initialLetterAscii = 64;

	return str
		.toUpperCase()
		.split("")
		.reduce((sum, char) => sum + char.charCodeAt(0), 0);
}
