var strStr = function(haystack, needle) {
    check= haystack.includes(needle)
    if(check===false){
        return -1
    }
   index=haystack.indexOf(needle)
   return index
    
};