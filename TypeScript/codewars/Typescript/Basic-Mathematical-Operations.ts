export function basicOp(operation: string, value1: number, value2: number): number {
	const Operations = {
		addition: "+",
		division: "/",
		multiplication: "*",
		subtraction: "-",
	};

	if (operation === Operations.addition) return value1 + value2;
	if (operation === Operations.subtraction) return value1 - value2;
	if (operation === Operations.multiplication) return value1 * value2;
	if (operation === Operations.division) return value1 / value2;

	return 0;
}
