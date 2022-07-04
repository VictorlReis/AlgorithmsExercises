/**
 * @param {number[]} nums
 * @return {number[]}
 */
const removeDuplicates = function(nums) {
    let l = 1;
    for(let i = 1; i < nums.length; i++) {
        if(nums[i] === nums[i - 1]) continue;

        nums[l] = nums[i];
        l++;
    }

    nums.splice(l,l);

    return nums;
};

console.log(removeDuplicates([0,0,1,1,1, 2, 2, 3,3,4]));
