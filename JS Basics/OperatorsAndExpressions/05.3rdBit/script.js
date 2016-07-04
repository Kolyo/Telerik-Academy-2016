function solve(args) {
    var n = +args[0];

    var bits = n.toString(2);
    if (bits.length >= 3) {
        return bits[bits.length - 3];
    }
    else {
        return '0';
    }

}
