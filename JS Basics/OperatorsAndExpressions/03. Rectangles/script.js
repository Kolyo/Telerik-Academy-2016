function solve(args) {
    var w = +args[0];
    var h = +args[1];
    var p = (w + h) * 2;
    var area = w * h;
    return area.toFixed(2) + ' ' + p.toFixed(2);

}