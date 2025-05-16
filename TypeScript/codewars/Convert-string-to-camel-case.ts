export function toCamelCase(str: string): string {
	const regex = /[-_]/g;

	const newStr = str
		.replace(regex, " ")
		.split(" ")
		.map((value, index) => {
			if (index !== 0) {
				const firstLetter = (value[0] ?? "").toUpperCase();
				return firstLetter + value.slice(1);
			}

			return value;
		});

	return newStr.join("");
}
