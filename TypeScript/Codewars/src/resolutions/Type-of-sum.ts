// biome-ignore lint/suspicious/noExplicitAny: <explanation>
export function typeOfSum(a: any, b: any): string {
	return typeof (a + b);
}
