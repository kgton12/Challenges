console.log(lengthOfLastWord("luffy is still joyboy"));
function lengthOfLastWord(s: string): number {
	const word = s.trim().split(" ");

	return word[word.length - 1].length;
}
