export function updateLight(current: string): string {
	const lightsSequence: Record<string, string> = {
		green: "yellow",
		yellow: "red",
		red: "green",
	};
	return lightsSequence[current];
}
