var scoreOfString = function(s) {
    let sum=0
  for(i=0;i<s.length-1;i++){
     sub= s.charCodeAt(i)-s.charCodeAt(i+1)
      sum+=Math.abs(sub)
    }
    return sum
};