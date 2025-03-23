export function smallEnough(a: number[], limit: number): boolean {
	return !(a.filter((value) => value > limit).length > 0);
}
