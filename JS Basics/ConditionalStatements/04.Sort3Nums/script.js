function solve(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2],
        out = '';
    if (a >= b && a >= c) {

        if (b >= c) {
            return a + ' ' + b + ' ' + c;
        } else {
            return a + ' ' + c + ' ' + b;
        }
    }
    if (b >= c && b >= a) {
        if (a >= c) {
            return b + ' ' + a + ' ' + c;
        } else {
            return b + ' ' + c + ' ' + a;
        }
    } else {
        if (a >= b) {
            return c + ' ' + a + ' ' + b;
        } else {
            return c + ' ' + b + ' ' + a;
        }
    }

}

console.log(solve(['0', '-2.5', '2.6']));
