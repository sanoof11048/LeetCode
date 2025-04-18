var countAndSay = function(n) {
  if(n==1){
    return String(n)
  }
  result=["1"]
  var dosome = function(result){
  res=[]
       for(i=0;i<result.length;i++){
        count=0
        if( result.indexOf(result[i])==result.lastIndexOf(result[i]) || result[i]!=result[i+1] && result[i]<=result.length){
            res.push(String(1))
            res.push(result[i])
        }else{
            do{
                count++
            }while(result[count+i]==result[i])
            res.push(String(count))
            res.push(result[i])
            i+=count-1
        }
    }
    return res
  }
     for(j=1;j<n;j++){
         console.log(j)
      var result = dosome(result)
  }
    return result.join("")
};
