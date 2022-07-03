function printLinkedList(head) {
    while(head.next != null){
        console.log(head.data);
        head = head.next;
    }

    console.log(head.data);
}