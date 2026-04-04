export function correct(s: string): string {
	return s.replaceAll("0", "O").replaceAll("1", "I").replaceAll("5", "S");
}
