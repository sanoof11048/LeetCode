var largestNumber = function(nums) {
    toStr= nums.map(num=>num.toString())
    toStr.sort((a,b)=> (b+a)-(a+b))
    if (toStr[0] === "0") {
        return "0";
    }
    return toStr.join('')
    
};