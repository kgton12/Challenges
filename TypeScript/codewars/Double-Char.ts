export function doubleChar(str: string): string {
	return [...str].map((value) => value.repeat(2)).join("");
}

console.log(doubleChar("abc"));
