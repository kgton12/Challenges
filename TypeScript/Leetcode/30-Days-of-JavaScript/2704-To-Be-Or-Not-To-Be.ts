type ToBeOrNotToBe = {
	toBe: (toBe: any) => boolean;
	notToBe: (val: any) => boolean;
};

function expect<T>(val: T): ToBeOrNotToBe {
	return {
		notToBe: (toBe: T) => {
			if (val !== toBe) return true;

			throw new Error("Equal");
		},
		toBe: (toBe: T) => {
			if (val === toBe) return true;

			throw new Error("Not Equal");
		},
	};
}


console.log(expect(5).toBe(null));
console.log(expect(5).notToBe(5));

