function insertNodeAtTail(head, data) {
    let newNode = new SinglyLinkedListNode(data);

    if(!head) {
        head = newNode;
        return head;
    }

    let c = head;

    while(c.next) {
        c = c.next;
    }

    c.next = newNode

    return head;
}