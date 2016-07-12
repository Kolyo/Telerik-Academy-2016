function solve(args) {
    var n = +args[0],
        mask = 1 << 3, out;
    out = n & mask;

    return out >> 3;
}
console.log(solve(['1024']));