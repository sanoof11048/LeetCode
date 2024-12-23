function addTwoNumbers(l1, l2) {
    let dummyHead = { val: 0, next: null };
    let current = dummyHead;
    let carry = 0;

    while (l1 !== null || l2 !== null || carry > 0) {
       
        let val1 = l1 ? l1.val : 0;
        let val2 = l2 ? l2.val : 0;

 
        let sum = val1 + val2 + carry;
        carry = Math.floor(sum / 10); 
        current.next = { val: sum % 10, next: null };
        current = current.next;
        if (l1) l1 = l1.next;
        if (l2) l2 = l2.next;
    }

    return dummyHead.next; 
}


function arrayToLinkedList(arr) {
    let dummyHead = { val: 0, next: null };
    let current = dummyHead;
    for (let num of arr) {
        current.next = { val: num, next: null };
        current = current.next;
    }
    return dummyHead.next;
}

function linkedListToArray(node) {
    let result = [];
    while (node !== null) {
        result.push(node.val);
        node = node.next;
    }
    return result;
}
