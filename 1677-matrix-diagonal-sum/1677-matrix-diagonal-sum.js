var diagonalSum = function(mat) {
    var length=mat.length
    var even=length%2
    let sum=0
    for(i=0;i<length;i++){
        sum+=mat[i][i]
        if(length-i-1!=i){
        sum+=mat[i][length-i-1]
        }
    }
    return sum
};