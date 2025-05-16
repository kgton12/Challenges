export function myFirstInterpreter(code: string): string {
	const output: string[] = [];
	let memory_cell = 0;

	for (const element of code) {
		if (element === "+") {
			memory_cell = (memory_cell + 1) % 256;
		} else if (element === ".") {
			output.push(String.fromCharCode(memory_cell));
		}
	}

	return output.join("");
}
