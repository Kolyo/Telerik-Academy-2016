function solve(args) {
    var a = +args[0];
    var b = +args[1];

    if (a > b) {
        a += b;
        b = a - b;
        a = a - b;
    }
    return a + ' ' + b;
}