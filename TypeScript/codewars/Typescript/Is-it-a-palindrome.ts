export function isPalindrome(x: string): boolean {
	const xLowerCase = x.toLocaleLowerCase();

	return xLowerCase === xLowerCase.split("").reverse().join("");
}
