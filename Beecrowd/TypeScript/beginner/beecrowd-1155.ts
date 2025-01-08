let sum = 1;

for (let index = 2; index <= 100; index++) {
	sum += 1 / index;
}

console.log(sum.toFixed(2));
