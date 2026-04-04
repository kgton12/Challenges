export function friend(friends: string[]): string[] {
	return friends.filter((value) => value.length === 4);
}
