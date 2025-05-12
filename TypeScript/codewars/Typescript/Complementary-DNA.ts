export class Kata {
	dnaStrand(dna: string) {
		const arrayValues: Record<string, string> = { A: "T", T: "A", C: "G", G: "C" };

		return dna
			.split("")
			.map((value) => {
				return arrayValues[value];
			})
			.join("");
	}
}
