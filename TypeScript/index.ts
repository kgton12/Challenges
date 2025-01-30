console.log(t([1,1,2,3]))

function t(nums: number[]): string {


	const arrayNums: string[] = [];

	for (let i = 0; i < nums.length; i++) {
		if (![nums[i]].includes(i)) {
			arrayNums.push(nums[i].toString());
		}
	}

	const diff = "_".repeat(nums.length - arrayNums.length);

	return [arrayNums, diff].join(",");


}