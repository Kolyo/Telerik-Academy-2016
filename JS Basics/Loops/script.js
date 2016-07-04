function solve(args) {
    var a = +args[0];
    var b = +args[1];
    var c = +args[2];

    if (a < b) {
        a = b;
    }
    if (a < c) {
        a = c;
    }
    return a;
}
console.log(
    solve([8,3,6]));