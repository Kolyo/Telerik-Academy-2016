function solve(args) {
    var x = +args[0];

    if (x <= 1) {
        return 'false';
    } else {
        for (var i = 2; i <= Math.sqrt(x); i++) {
            if (x % i === 0) {
                return 'false';
            }
        }
        return 'true';
    }
}
