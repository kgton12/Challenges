import { readFileSync } from "node:fs";
import { EOL } from "node:os";
import { stdin } from "node:process";

const input = readFileSync(stdin.fd, { encoding: "utf8" }).split(EOL).map(Number);
// const input = [8, 1, 7, 2, 2, 4];

const values = input.filter((value) => value > 0 && value < 5);
const fuelTypes = {
    gasoline: 0,
    alcohol:0,
    diesel:0
}

for (const element of values) {

    if(element === 4){
        break;
    }
    
    switch (element) {
        case 1:
            fuelTypes.alcohol++;
            break;
        case 2:
            fuelTypes.gasoline++;
            break;
        case 3:
            fuelTypes.diesel++;
            break;
        default:
            break;
    }
}

console.log("MUITO OBRIGADO");
console.log(`Alcool: ${fuelTypes.alcohol}`);
console.log(`Gasolina: ${fuelTypes.gasoline}`);
console.log(`Diesel: ${fuelTypes.diesel}`);

