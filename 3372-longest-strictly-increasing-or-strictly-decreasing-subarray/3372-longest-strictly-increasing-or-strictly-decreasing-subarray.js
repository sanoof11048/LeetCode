/**
 * @param {number[]} nums
 * @return {number}
 */
var longestMonotonicSubarray = function(nums) {
    let maxLeng=1
    let incLen=1
    let decLen=1
    for(let i=1;i<nums.length;i++){
        if(nums[i]>nums[i-1]){
            incLen+=1
            decLen=1
        }
        else if(nums[i]<nums[i-1]){
            decLen+=1
            incLen=1
        }else{
            incLen=1
            decLen=1
        }
        maxLeng=Math.max(maxLeng,incLen,decLen)
    }
    return maxLeng
};