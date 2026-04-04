const vowelForNumber: Record<number, string> = {
	1: "a",
	2: "e",
	3: "i",
	4: "o",
	5: "u",
};

export function encode(string: string): string {
	let encodedString = string;

	for (const [key, vowel] of Object.entries(vowelForNumber)) {
		encodedString = encodedString.replaceAll(vowel, key);
	}

	return encodedString;
}

export function decode(string: string): string {
	let encodedString = string;

	for (const [key, vowel] of Object.entries(vowelForNumber)) {
		encodedString = encodedString.replaceAll(key, vowel);
	}

	return encodedString;
}
