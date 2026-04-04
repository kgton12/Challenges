import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

// const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
const __filename = fileURLToPath(import.meta.url);
const __dirname = dirname(__filename);
const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

let index = 0;

type IFriend = {
	name: string;
	choice: string;
	length: number;
};

const Chose = {
	YES: "YES",
	NO: "NO",
	END: "FIM",
};

const friends: IFriend[] = [];

while (input[index]?.trim() !== Chose.END) {
	const [name, choice] = input[index].split(" ");

	friends.push({ name, choice, length: name.length });

	index++;
}

const FriendsChosenYes = getSortedUniqueNames(friends, Chose.YES);
const FriendsChosenNo = getSortedUniqueNames(friends, Chose.NO);
const chosenFriend = getChosenFriend(friends, Chose.YES);

const uniqueFriendNames = new Set([...FriendsChosenYes, ...FriendsChosenNo]);

Array.from(uniqueFriendNames).map((value) => console.log(value));
console.log("");
console.log("Amigo do Habay:");
console.log(chosenFriend.name);

function getSortedUniqueNames(friends: IFriend[], choice: string): string[] {
	return friends
		.filter((friend) => friend.choice === choice)
		.map((friend) => friend.name)
		.filter((name, index, arr) => arr.indexOf(name) === index)
		.sort((a, b) => a.localeCompare(b));
}

function getChosenFriend(yesFriends: IFriend[], choice: string): IFriend {
	return yesFriends
		.filter((friend) => friend.choice === choice)
		.reduce((prev, curr) => (curr.length > prev.length ? curr : prev), yesFriends[0]);
}
