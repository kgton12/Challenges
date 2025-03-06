import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { dirname, join } from "node:path";
import { stdin } from "node:process";
import { fileURLToPath } from "node:url";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL);
// const __filename = fileURLToPath(import.meta.url);
// const __dirname = dirname(__filename);
// const input = readFileSync(join(__dirname, "..", "file.txt"), "utf-8").split(EOL);

const killersMap = new Map<string, number>();
const murderedSet = new Set<string>();

for (const element of input) {
	if (element.trim() === "") break;

	const [killer, murdered] = element.split(" ");

	murderedSet.add(murdered);
	killersMap.set(killer, (killersMap.get(killer) || 0) + 1);
}

for (const killer of Array.from(killersMap.keys())) {
	if (murderedSet.has(killer)) {
		killersMap.delete(killer);
	}
}

console.log("HALL OF MURDERERS");
Array.from(killersMap.entries())
	.sort((a, b) => a[0].localeCompare(b[0]))
	.map(([name, quantity]) => console.log(`${name} ${quantity}`));
