export const scale = (s: string, k: number, n: number): string => {
	if (s.trim() === "") return "";

	return s
		.split("\n")
		.map((line) => repeatLetters(line, k))
		.flatMap((scaledLine) => Array(n).fill(scaledLine))
		.join("\n");
};

function repeatLetters(str: string, quantity: number): string {
	return [...str].map((char) => char.repeat(quantity)).join("");
}
