export function reverseWords(str: string): string {
	return str
		.split(" ")
		.map((value) => [...value].reverse().join(""))
		.join(" ");
}

console.log(reverseWords("double  spaces"));
