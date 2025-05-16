export function getGrade(a: number, b: number, c: number): string {
	const GRADE = {
		A: "A",
		B: "B",
		C: "C",
		D: "D",
		F: "F",
	};

	const avg = (a + b + c) / 3;

	if (avg >= 90) return GRADE.A;
	if (avg >= 80) return GRADE.B;
	if (avg >= 70) return GRADE.C;
	if (avg >= 60) return GRADE.D;
	return GRADE.F;
}
