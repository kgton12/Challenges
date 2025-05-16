export function countSheeps(arrayOfSheep: (boolean | undefined | null)[]) {
	return arrayOfSheep.filter((value) => value === true).length;
}
