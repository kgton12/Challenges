export function switcheroo(x: string): string {
	return x
		.split("")
		.map((value) => {
			if (value === "a") return "b";
			if (value === "b") return "a";
			return value;
		})
		.join("");
}
