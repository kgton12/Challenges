export function remove(s: string): string {
	return `${s.replaceAll("!", "")}!`;
}
console.log(remove("Hi!!! Hi!!!"));
