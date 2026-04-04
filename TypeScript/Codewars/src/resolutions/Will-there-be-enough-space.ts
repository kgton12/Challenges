export function enough(cap: number, on: number, wait: number): number {
	const onWait = on + wait;

	return cap >= onWait ? 0 : onWait - cap;
}
