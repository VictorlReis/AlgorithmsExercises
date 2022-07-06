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

console.log(plusOne([9,9,9]));
