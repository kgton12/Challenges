class ListNode {
	val: number;
	next: ListNode | null;
	constructor(val?: number, next?: ListNode | null) {
		this.val = val === undefined ? 0 : val;
		this.next = next === undefined ? null : next;
	}
}

function mergeTwoLists(list1: ListNode | null, list2: ListNode | null): ListNode | null {
	const dummy = new ListNode();
	let cur = dummy;
	let auxList2 = list2;
	let auxList1 = list1;

	while (auxList1 && auxList2) {
		if (auxList1.val > auxList2.val) {
			cur.next = auxList2;
			auxList2 = auxList2.next;
		} else {
			cur.next = auxList1;
			auxList1 = auxList1.next;
		}
		cur = cur.next;
	}

	cur.next = auxList1 || auxList2;

	return dummy.next;
}
