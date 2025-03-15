export function printerError(s: string): string {
	const quantityPrinterError = s.split("").filter((value) => {
		return value.toLocaleLowerCase().charCodeAt(0) > 109;
	}).length;

	return `${quantityPrinterError}/${s.length}`;
}
