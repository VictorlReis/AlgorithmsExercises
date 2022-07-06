var plusOne = function(digits) {
    let c = digits.length -1;
    let i = 1;

    while(c >= 0 || i < 1) {
        if(digits[c] === 9) {
            digits[c] = 0;
            c--;
        } else {
            digits[c] += 1;
            i--;
            break;
        }
    }

    if(i === 1) digits = [1, ...digits];

    return digits;
};

var plusOne = function(digits) {
    for(let i = digits.length - 1; i >= 0; i--) {
        if(digits[i] < 9) {
            digits[i] += 1
            return digits;
        } else {
            digits[i] = 0;
        }
    }

    digits.unshift(1);
    return digits;
};

// time complexity = O(N)
// space complexity = O(1)

console.log(plusOne([9,9,9]));
