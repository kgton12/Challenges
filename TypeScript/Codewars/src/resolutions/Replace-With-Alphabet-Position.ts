export function alphabetPosition(text: string): string {
	const asciiValueOfA = 97;
	const regex = /[^a-zA-Z]/g;

	return text
		.replace(regex, "")
		.split("")
		.map((value) => value.toLocaleLowerCase().charCodeAt(0) - asciiValueOfA + 1)
		.join(" ");
}
