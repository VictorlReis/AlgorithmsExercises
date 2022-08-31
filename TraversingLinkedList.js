function ListNode(val, next) {
  this.val = (val===undefined ? 0 : val)
  this.next = (next===undefined ? null : next)
}

/**
 * @param {ListNode} head
 */
const traversingLinkedList = function(head) {

    while(head.next !== null) {
        console.log(head.val);
        head = head.next;
    }

    console.log(head.val)
}

traversingLinkedList(new ListNode(1, new ListNode(2, new ListNode(3, null))));
