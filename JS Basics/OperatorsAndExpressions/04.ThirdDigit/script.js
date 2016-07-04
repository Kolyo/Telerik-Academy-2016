function solve(args) {
    var n = args[0];

    if (n[n.length - 3] === '7') {
        return 'true'
    } else if (typeof n[n.length - 3] === 'undefined') {
        return 'false 0';
    } else {
        return 'false ' + n[n.length - 3];
    }
}