/**
 * @param {number} n
 * @param {string[]} commands
 * @return {number}
 */
var finalPositionOfSnake = function(n, commands) {
    var count=n*n
    var mainarr=[]
    var cur=0
    for(i=0;i<count;i++){
        mainarr[i]=i
    }
        console.log(mainarr)
        for(i=0;i<commands.length;i++){
            if(commands[i]=="DOWN"){
                cur+=n
            }
            else if(commands[i]=="UP"){
                cur-=n
            }
            else if(commands[i]=="RIGHT"){
                cur+=1
            }
            else if(commands[i]=="LEFT"){
                cur-=1
            }
        }
        return cur
};