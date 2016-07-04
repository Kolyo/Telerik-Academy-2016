function solve(args) {
    var a = +args[0];
    var b = +args[1];
    var c = +args[2];
    var counter = 0;

    if (a === 0 || b === 0 || c === 0) {
        console.log('0');
    }
    if (a < 0) {
        counter++;
    }
    if (b < 0) {
        counter++;
    }
    if (c < 0) {
        counter++;
    }
    if (counter % 2 === 0) {
        console.log('+');
    } else {
        console.log('-');
    }
}
console.log(solve(['5', '0', '2']));
