export function htmlspecialchars(formData: string): string {
	const htmlChars = new Map<string, string>([
		["<", "&lt;"],
		[">", "&gt;"],
		['"', "&quot;"],
		["&", "&amp;"],
	]);

	return [...formData].map((value) => htmlChars.get(value) ?? value).join("");
}

console.log(htmlspecialchars("<h2>Hello World</h2>"));
