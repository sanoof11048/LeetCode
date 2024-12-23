var removeDuplicates = function(nums) {
    length=nums.length
    if(length===0) return 0
    let unique =0
    for(i=1;i<length;i++){
        if(nums[i]!==nums[unique]){
            unique++
            nums[unique]=nums[i]
        }
    }
    return unique+1
};