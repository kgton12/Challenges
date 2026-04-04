export class Kata {
	validatePin(pin: string): boolean {
		const regex = /[^0-9]/g;

		return pin.replace(regex, "").length === pin.length && (pin.length === 4 || pin.length === 6);
	}
}
