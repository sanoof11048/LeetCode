var sumOfUnique = function(nums) {
   sum=0
    for(i=0;i<nums.length;i++){
        if(nums.indexOf(nums[i])==nums.lastIndexOf(nums[i])){
            sum+=nums[i]
        }
    }
    return sum 
};