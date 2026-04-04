export function sortMyString(s: string): string {
	const evenChars: string[] = [];
	const oddChars: string[] = [];

	for (let i = 0; i < s.length; i++) {
		if (i % 2 === 0) {
			evenChars.push(s[i]);
		} else {
			oddChars.push(s[i]);
		}
	}

	return `${evenChars.join("")}${" "}${oddChars.join("")}`;
}
