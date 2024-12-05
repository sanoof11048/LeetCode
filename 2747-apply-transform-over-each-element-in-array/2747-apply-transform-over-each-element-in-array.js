var map=function(arr, fn){
returnedArray=[]
for(i=0;i<arr.length;i++){
    returnedArray[i]=fn(arr[i],i)
}
return returnedArray
};