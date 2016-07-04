function solve(args) {
    var x = +args[0];
    var y = +args[1];
    var output = '';
    if (x >= -0.5 && x <= 2.5 && y >= -0.5 && y <= 2.5) {
        output += 'inside circle ';
    } else {
        output += 'outside circle ';
    }
    if (x >= -1 && x <= 5 && y >= -1 && y <= 1) {
        output += 'inside rectangle';
    } else {
        output += 'outside rectangle';
    }
    return output;
}
console.log(solve(['1', '2']));