console.log(isPalindrome(121));

function isPalindrome(x: number): boolean {
	if (x < 0 || (x % 10 === 0 && x !== 0)) return false;

	const result: string = x.toString().split("").reverse().join("");
	return result === x.toString();
}
