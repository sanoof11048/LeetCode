/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLastWord = function(s) {
    p=s.split(" ")
    a=[]
    j=0
    for(i=0;i<p.length;i++){
    if(p[i]!=""){
        a[j]=p[i]
        j++
    }
}
len=a.length-1
leng=a[len].length
return leng
    
};