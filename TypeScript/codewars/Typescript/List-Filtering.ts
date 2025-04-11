export function filter_list(l: Array<string | number>): Array<number> {
	return l.filter((value) => typeof value === "number");
}
