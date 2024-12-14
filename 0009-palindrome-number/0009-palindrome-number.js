var isPalindrome = function(x) {
    num=x.toString()

    rever=num.split('').reverse().join('')
    return (num==rever)? true: false;
};