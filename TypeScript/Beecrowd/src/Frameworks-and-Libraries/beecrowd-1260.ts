import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

// type ITree = {
// 	name: string;
// 	quantity: number;
// };

const I = Number(input.shift() ?? "0");
let index = 1;
let isFirst = true;

for (let j = 0; j < I; j++) {
	const treeMap = new Map<string, number>();

	while (index < input.length) {
		const element = input[index++];

		if (element === "" || element === "-1") break;

		treeMap.set(element, (treeMap.get(element) ?? 0) + 1);
	}

	if (isFirst) isFirst = false;
	else console.log("");

	const totalTreeCount = Array.from(treeMap.values()).reduce((prev, curr) => prev + curr, 0);

	Array.from(treeMap.entries())
		.sort(([a], [b]) => a.localeCompare(b))
		.map(([name, quantity]) => {
			const percentage = ((quantity / totalTreeCount) * 100).toFixed(4);
			console.log(`${name} ${percentage}`);
		});
}
