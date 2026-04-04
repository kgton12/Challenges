export function capitalize(s: string): [string, string] {
	return [toggleCase(s, false), toggleCase(s, true)];
}

function toggleCase(str: string, initialCaseIsLower: boolean): string {
	return str
		.split("")
		.map((value, index) => (index % 2 === (initialCaseIsLower ? 0 : 1) ? value.toLowerCase() : value.toUpperCase()))
		.join("");
}
