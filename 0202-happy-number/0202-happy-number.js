var isHappy = function(n) {
    var num = String(n).split('')
    count=num
    do{
    if(count.length<2 && count!=1 && count !=7){
        return false
    }
    var a= count.map(n=>n*n).reduce((a,b)=>a+b,0)
    var count=String(a).split('')
    }while(count!=1)
    
    if(count == 1 || count == 7){
        return true
    }
};