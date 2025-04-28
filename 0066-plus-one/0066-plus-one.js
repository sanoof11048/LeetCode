var plusOne = function(digits) {
    numStr = digits.join("")
    inc = BigInt(numStr) + 1n
    newArr1 = String(inc).split('').map(Number)
   return newArr1
};