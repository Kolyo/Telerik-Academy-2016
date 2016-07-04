function solve(args) {
    var num = +args[0];
    if (num % 35 === 0) {
        return 'true ' + num;
    } else {
        return 'false ' + num;
    }
}