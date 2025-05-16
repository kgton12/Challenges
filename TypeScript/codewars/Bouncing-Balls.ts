export function bouncingBall(h: number, bounce: number, window: number): number {
	let heightValue = h;

	if (heightValue <= 0 || bounce <= 0 || bounce >= 1 || window >= heightValue) {
		return -1;
	}

	let totalPasses = 0;

	while (heightValue > window) {
		totalPasses++;

		if (heightValue * bounce > window) {
			totalPasses++;
		}

		heightValue *= bounce;
	}

	return totalPasses;
}
