type ToBeOrNotToBe<T> = {
	toBe: (value: T) => boolean;
	notToBe: (value: T) => boolean;
};

function expect<T>(val: T): ToBeOrNotToBe<T> {
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

console.log(expect<number | null>(5).toBe(null));
console.log(expect(5).notToBe(5));
