function add(n1, n2) {
	let a = n1;
	let b = n2;

	while (b !== 0) {
		const carry = a & b;
		a = a ^ b;
		b = carry << 1;
	}
	return a;
}
