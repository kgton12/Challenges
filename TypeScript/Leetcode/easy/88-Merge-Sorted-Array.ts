merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);

function merge(nums1: number[], m: number, nums2: number[], n: number): void {
	[...nums1, ...nums2]
		.filter((element) => {
			return element !== 0;
		})
		.sort((a, b) => a - b)
		.map((value, index) => {
			nums1[index] = value;
		});

	console.log(nums1);
}
