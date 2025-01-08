let multiple = 2;
let sum = 1;

for (let index = 3; index <= 39; index = index + 2) {
	sum += index / multiple;
	multiple *= 2;
}

console.log(sum.toFixed(2));
