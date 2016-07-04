function solve(args) {
    var a = +args[0];
    var b = +args[1];
    var c = +args[2];
    var d = +args[3];
    var e = +args[4];
    if (a < b) {
        a = b;
    }
    if (a < c) {
        a = c;
    }
    if (a < d) {
        a = d;
    }
    if (a < e) {
        a = e;
    }
    return a;

}

console.log(solve(['2', '3', '11', '6', '7']));
