export function hello(name = ""): string {
	const correctName = name === "" ? "World" : analyzeWord(name);

	return `Hello, ${correctName}!`;
}

function analyzeWord(str: string): string {
	return str[0].toUpperCase() + str.slice(1).toLowerCase();
}
