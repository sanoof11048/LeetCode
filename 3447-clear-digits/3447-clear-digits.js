var clearDigits = function(s) {
var result=[]
var flag=false
  s.split('')
  for(i=0;i<s.length;i++){
    flag=false
      for(j=0;j<10;j++){
        if(s[i]==j){
          result.pop()
          flag=true
          result=result.join('').split('')
          break;
        }
      }
      if(!flag){

        result[i]=s[i]
      }
  }
  return result.join('')
}
