var containsDuplicate = function(nums) {
    sorted=nums.sort((a,b)=>a-b)
    for(i=0;i<sorted.length;i++){
            if(sorted[i]===sorted[i+1]){
                return true
        }
    }
    return false
};