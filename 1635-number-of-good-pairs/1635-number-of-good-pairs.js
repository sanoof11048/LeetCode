var numIdenticalPairs = function(nums) {
    let count = 0
    for(i=0;i<nums.length;i++){
        for(j=0;j<nums.length;j++){
            if(nums[i]==nums[j]&&i<j)
            count++
        }
    }
    return count
};