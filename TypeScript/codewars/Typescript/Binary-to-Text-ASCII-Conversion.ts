export function binaryToString(binary: string) {
	const arrayBinary = binary.match(/.{1,8}/g) || [];

	return arrayBinary.map((value: string) => String.fromCharCode(Number.parseInt(value, 2))).join("");
}
