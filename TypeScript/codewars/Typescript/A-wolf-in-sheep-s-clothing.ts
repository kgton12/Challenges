export function warnTheSheep(queue: string[]): string {
	if (queue[queue.length - 1] === "wolf") return "Pls go away and stop eating my sheep";

	const targetedSheepIndex = queue.length - 1 - queue.findIndex((value) => value === "wolf");

	return `Oi! Sheep number ${targetedSheepIndex}! You are about to be eaten by a wolf!`;
}
