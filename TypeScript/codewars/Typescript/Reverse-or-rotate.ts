console.log(revRot("733049910872815764", 5));

export function revRot(s: string, sz: number): string {
	if (s.trim() === "" || sz <= 0 || sz > s.length) return "";

	const output: string[] = [];

	const len = Math.trunc(s.length / sz);

	for (let index = 0; index < len; index++) {
		const arrayValue = s
			.substring(index * sz, index * sz + sz)
			.split("")
			.map(Number);

		const isEven = arrayValue.reduce((prev, curr) => prev + curr, 0) % 2 === 0;

		if (isEven) output.push(arrayValue.reverse().join(""));
		else {
			arrayValue.push(arrayValue.shift() ?? 0);

			output.push(arrayValue.join(""));
		}
	}

	return output.join("");
}
