var maximumCount = function(nums) {
    pos=0
    neg=0
    for(i=0;i<nums.length;i++){
        if(nums[i]<0){
            neg++
        }
        if(nums[i]>0){
            pos++
        }
    }
    return Math.max(pos,neg)
};