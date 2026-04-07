//Doubleton number
export function doubleton(num: number): number {
 
   let i = num + 1;
   
        while (!IsDoubletonNumber(i))
            i++;

    return i;
} 

function  IsDoubletonNumber(n:number): boolean {
    return n.toString().split("").reverse().length == 2;
}