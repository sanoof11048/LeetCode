var buildArray = function(nums) {
    result = []
    for(i=0;i<nums.length;i++){
        result[i]=nums[nums[i]]
    }
    return result
};