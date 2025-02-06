var areAlmostEqual = function(s1, s2) {
    if(s1===s2) return true;
    var diff=[]
    for(i=0;i<s1.length;i++){
        if(s1[i]!=s2[i]){
            diff.push(i)
            if(diff.length>2) return false
        }
    }
    return diff.length==2 && 
    s1[diff[0]]== s2[diff[1]] &&
    s1[diff[1]]== s2[diff[0]]
}