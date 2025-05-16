export function solution(str: string, ending: string): boolean {
	if (ending === "") return true;

	const substringFromEnd = str.slice(ending.length * -1);

	return substringFromEnd === ending;
}
