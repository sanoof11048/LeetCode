function ArrayWrapper(nums) {
  return {
    nums,
    valueOf: () => nums.reduce((sum, num) => sum + num, 0),
    toString: () => `[${nums.join(",")}]`
  };
}