
function binarySearchIterative(list, item) {
    let start = 0, end = list.length - 1;

    while(start <= end) {
        let mid = Math.floor((start + end) / 2);

        if(list[mid] === item) return mid;
        else if(list[mid] < item) start = mid + 1;
        else end = mid - 1;
    }
}

function binarySearchRecursive(array, item, begin ,end) {
    if( begin <= end) {
        let mid = Math.floor((begin + end) / 2);

        if(array[mid] === item) return array[mid];

        if(item < array[mid]) return binarySearchRecursive(array, item, begin, mid - 1)
        else return binarySearchRecursive(array, item, mid + 1, end);
    }
        return null;
}
