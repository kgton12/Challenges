export function automorphic(n: number): string {
	return String(n ** 2).endsWith(String(n)) ? "Automorphic" : "Not!!";
}
