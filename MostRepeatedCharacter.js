const solution = function(s) {

    let hChar = "";
    let hCount = 0;

    for(let i = 0; i < s.length; i++) {
        const char = s[i];

        if(!(char.toUpperCase() !== char.toLowerCase())) continue;

        let tempCount = 0

        for(let j = 0; j < s.length; j++) {
            if(s[j] === char) tempCount++;
        }

        if(tempCount > hCount) {
            hChar = char;
            hCount = tempCount;
        }
    }

    return hChar;
}

console.log(solution("wpobbbbjfaaaaaaaaaaaaawepofjwpbb345430-9-11111111111111bofb1235"));
