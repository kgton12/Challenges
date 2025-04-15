export function switchItUp(intNumber: number): string {
	const numbersInWriting = [
		{
			number: 1,
			writing: "One",
		},
		{
			number: 2,
			writing: "Two",
		},
		{
			number: 3,
			writing: "Three",
		},
		{
			number: 4,
			writing: "Four",
		},
		{
			number: 5,
			writing: "Five",
		},
		{
			number: 6,
			writing: "Six",
		},
		{
			number: 7,
			writing: "Seven",
		},
		{
			number: 8,
			writing: "Eight",
		},
		{
			number: 9,
			writing: "Nine",
		},
	];

	const found = numbersInWriting.find((value) => value.number === intNumber);
	return found ? found.writing : "";
}

console.log(switchItUp(2));
