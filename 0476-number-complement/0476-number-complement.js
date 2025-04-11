var findComplement = function (num) {
    num2 = num.toString(2).split("")
    for (i = 0; i < num2.length; i++) {
        num2[i] == 0 ? num2[i] = 1 : num2[i] = 0
    }
    res = num2.join("")
    return parseInt(res, 2)
};