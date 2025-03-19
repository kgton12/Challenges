export function get_age(age: string): number {
	return Number.parseInt(age.split(" ")[0]);
}
