'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', function(inputStdin) {
    inputString += inputStdin;
});

process.stdin.on('end', function() {
    inputString = inputString.split('\n');

    main();
});

function readLine() {
    return inputString[currentLine++];
}

/*
 * Complete the 'countApplesAndOranges' function below.
 *
 * The function accepts following parameters:
 *  1. INTEGER s = 7
 *  2. INTEGER t = 11
 *  3. INTEGER a = 5
 *  4. INTEGER b = 15
 *  5. INTEGER_ARRAY apples = 2,6,5
 *  6. INTEGER_ARRAY oranges = 5, -6
 */

function countApplesAndOranges(s, t, a, b, apples, oranges) {
    //  1. INTEGER s = 7
    //  2. INTEGER t = 11
    //  3. INTEGER a = 5
    //  4. INTEGER b = 15
    //  5. INTEGER_ARRAY apples = -2,2,1
    //  6. INTEGER_ARRAY oranges = 5, -6

    let appleCount = 0;
    let orangeCount = 0;

    for(let i = 0; i < apples.length; i++) {
        apples[i] += a;

        if(apples[i] >= s && apples[i] <= t) appleCount++;
    }

    for(let i =0; i < oranges.length; i++) {
        oranges[i] += b;

        if(oranges[i] >= s && oranges[i] <= t) orangeCount++;
    }

    console.log(appleCount);
    console.log(orangeCount);
}

function main() {
    const firstMultipleInput = readLine().replace(/\s+$/g, '').split(' ');

    const s = parseInt(firstMultipleInput[0], 10);

    const t = parseInt(firstMultipleInput[1], 10);

    const secondMultipleInput = readLine().replace(/\s+$/g, '').split(' ');

    const a = parseInt(secondMultipleInput[0], 10);

    const b = parseInt(secondMultipleInput[1], 10);

    const thirdMultipleInput = readLine().replace(/\s+$/g, '').split(' ');

    const m = parseInt(thirdMultipleInput[0], 10);

    const n = parseInt(thirdMultipleInput[1], 10);

    const apples = readLine().replace(/\s+$/g, '').split(' ').map(applesTemp => parseInt(applesTemp, 10));

    const oranges = readLine().replace(/\s+$/g, '').split(' ').map(orangesTemp => parseInt(orangesTemp, 10));

    countApplesAndOranges(s, t, a, b, apples, oranges);
}
