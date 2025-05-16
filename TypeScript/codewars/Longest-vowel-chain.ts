export function solve(s: string) {
	const vowels = ["a", "e", "i", "o", "u"];
	const result: number[] = [];
	let count = 0;

	for (const element of s) {
		if (vowels.includes(element)) count++;
		else {
			result.push(count);
			count = 0;
		}
	}

	return Math.max(...result);
}

console.log(solve("iiihoovaeaaaoougjyaw"));
