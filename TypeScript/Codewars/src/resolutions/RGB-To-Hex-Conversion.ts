export function rgb(r: number, g: number, b: number): string {
	const rgb = [r, g, b];
	const output: string[] = [];

	rgb.map((value) => {
		output.push(convertDecInHex(value));
	});

	return output.join("");
}

function convertDecInHex(n: number): string {
	let tempValue = n;

	if (n < 0) tempValue = 0;

	if (n > 255) tempValue = 255;

	return tempValue.toString(16).padStart(2, "0").toUpperCase();
}
