console.log(longestCommonPrefix(["cir", "car"]));

function longestCommonPrefix(stringArray: string[]): string {
	let result = "";

	// const arrayWithSmallestSize = stringArray.reduce((prev, current) => {
	//     return prev.length < current.length ? prev : current;
	// }, stringArray[0]);
	const arrayWithSmallestSize = stringArray.sort((a, b) => a.length - b.length)[0];

	for (let index = 0; index < arrayWithSmallestSize.length; index++) {
		const value = arrayWithSmallestSize.charAt(index);

		if (
			stringArray.every((string) => {
				return string.charAt(index) === value;
			})
		) {
			result += value;
		} else {
			break;
		}
	}

	return result;
}
