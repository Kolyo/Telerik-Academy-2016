function solve(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2],
        d = 0,
        x1 = 0,
        x2 = 0;

    d = b * b - 4 * a * c;

    if (d === 0) {
        x1 = -b / (2 * a);
        console.log('x1=x2=' + x1.toFixed(2));
    } else if (d < 0) {
        console.log('no real roots');
    }
    else {
        x1 = (-b - Math.sqrt(b * b - 4 * a * c)) / (2 * a);
        x2 = (-b + Math.sqrt(b * b - 4 * a * c)) / (2 * a);
        console.log('x1=' + x1.toFixed(2) + '; x2=' + x2.toFixed(2));
    }
}

console.log(solve(['2', '5', '-3']));
