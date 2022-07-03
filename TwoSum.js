
/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
const twoSum2loops = function(nums, target) {
    let arr = [];

    for(let i = 0; i < nums.length; i++) {
        for(let j = i+1; j < nums.length; j++) {
            if(nums[i] + nums[j] === target) {
                arr.push(i);
                arr.push(j);
                return arr;
            }
        }
    }

    return arr;
};

const twoSum = function(nums, target) {
    let map = {};

    for(let i = 0; i < nums.length; i++) {
        let value = nums[i];
        let complementPair = target - value;

        if(map[complementPair] !== undefined) return [map[complementPair],i];
        map[value] = i;
    }
};

console.log(twoSum([2,5,5,11], 10));


