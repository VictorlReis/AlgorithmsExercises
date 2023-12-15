const moveZeroes = (nums) => {
  let left = 0, right = 0;
  while (right < nums.length) {
    if (nums[right] !== 0) {
      console.log(nums[left], nums[right]);
      [nums[left], nums[right]] = [nums[right], nums[left]];
      left++;
    }
    right++;
  }
  return nums;
}

console.log(moveZeroes([1, 3, 12, 0, 0]))
