var maximum69Number  = function(num) {
    arrNum = num.toString().split('')
    for(i=0;i<arrNum.length;i++){
        if(arrNum[i]==6){
            arrNum[i]=9
            break;
        }
    }
    return +arrNum.join('')
};