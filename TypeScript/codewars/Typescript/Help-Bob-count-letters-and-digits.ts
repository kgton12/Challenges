export function countLettersAndDigits(input: string): number {
	const regex = /[^0-9A-Za-z]/g;

	return input.replace(regex, "").length;
}

console.log(countLettersAndDigits("12345f%%%t5t&/6"));
