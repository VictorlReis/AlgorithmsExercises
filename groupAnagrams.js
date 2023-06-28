var groupAnagrams = function(strs) {
    const strSorted = [];
    const resultMap = {};

    for (let i = 0; i < strs.length; i++) {
        let t = strs[i].split('').sort((a, b) => a.localeCompare(b)).join('');
        strSorted.push(t);
    }

    for (let i = 0; i < strs.length; i++) {
        if(strSorted[i] === strs[i].split('').sort((a, b) => a.localeCompare(b)).join('')) {
            if (!resultMap[strSorted[i]]) {
                resultMap[strSorted[i]] = [];
            }

            resultMap[strSorted[i]].push(strs[i]);
        }

    }
    return Object.values(resultMap);
};

const koft = groupAnagrams(["eat","tea","tan","ate","nat","bat"])

console.log(koft);