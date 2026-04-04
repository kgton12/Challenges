export function longestConsec(strarr: string[], k: number): string {
	if (strarr.length === 0 || k > strarr.length || k <= 0) {
		return "";
	}

	let longest = "";

	for (let i = 0; i <= strarr.length - k; i++) {
		const concatStr = strarr.slice(i, i + k).join("");

		if (concatStr.length > longest.length) {
			longest = concatStr;
		}
	}

	return longest;
}
