function removeElement(numberList: number[], val: number): number {
	while (true) {
		if (numberList.includes(val)) {
			numberList.splice(numberList.indexOf(val), 1);
		} else break;
	}

	return numberList.length;
}
