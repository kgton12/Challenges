export function numPrimorial(n: number): number {
	const primes = generatePrimes(n);
	return primes.reduce((product, value) => product * value, 1);
}

function generatePrimes(count: number): number[] {
	const primes: number[] = [];
	let num = 2;

	while (primes.length < count) {
		if (isPrime(num)) primes.push(num);
		num++;
	}

	return primes;
}

function isPrime(num: number): boolean {
	if (num < 2) return false;
	const sqrt = Math.sqrt(num);
	for (let i = 2; i <= sqrt; i++) {
		if (num % i === 0) return false;
	}
	return true;
}
