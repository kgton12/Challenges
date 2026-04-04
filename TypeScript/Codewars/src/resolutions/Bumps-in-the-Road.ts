export function bump(x: string): string {
	const regex = /[_]/g;
	return x.replaceAll(regex, "").length > 15 ? "Car Dead" : "Woohoo!";
}

console.log(bump("_nnnnnnn_n__n______nn__nn_"));
