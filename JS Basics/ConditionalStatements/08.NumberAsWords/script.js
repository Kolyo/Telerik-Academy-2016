function solve(args) {
    var a = args[0], out = '';

    if (+a === 0) {
        return 'zero';
    }
    switch (+a[a.length - 3]) {
        case 1:
            out += 'one hundred and ';
            break;
        case 2:
            out += 'two hundred and ';
            break;
        case 3:
            out += 'three hundred and ';
            break;
        case 4:
            out += 'four hundred and ';
            break;
        case 5:
            out += 'five hundred and ';
            break;
        case 6:
            out += 'six hundred and ';
            break;
        case 7:
            out += 'seven hundred and ';
            break;
        case 8:
            out += 'eight hundred and ';
            break;
        case 9:
            out += 'nine hundred and ';
            break;
        default:
            out += '';

    }

    if (a[a.length - 2] <= 2) {
        switch (+(a[a.length - 2].concat(a[a.length - 1]))) {
            case 0:
                out += 'zero';
                break;
            case 1:
                out += 'one';
                break;
            case 2:
                out += 'two';
                break;
            case 3:
                out += 'three';
                break;
            case 4:
                out += 'four';
                break;
            case 5:
                out += 'five';
                break;
            case 6:
                out += 'six';
                break;
            case 7:
                out += 'seven';
                break;
            case 8:
                out += 'eight';
                break;
            case 9:
                out += 'nine';
                break;
            case 10:
                out += 'ten';
                break;
            case 11:
                out += 'eleven';
                break;
            case 12:
                out += 'twelve';
                break;
            case 13:
                out += 'thirteen';
                break;
            case 14:
                out += 'fourteen';
                break;
            case 15:
                out += 'fifteen';
                break;
            case 16:
                out += 'sixteen';
                break;
            case 17:
                out += 'seventeen';
                break;
            case 18:
                out += 'eighteen';
                break;
            case 19:
                out += 'nineteen';
                break;
            case 20:
                out += 'twenty';
                break;
        }
    } else {
        switch (+a[a.length - 2]) {
            case 3:
                out += 'thirty ';
                break;
            case 4:
                out += 'fourty ';
                break;
            case 5:
                out += 'fifty ';
                break;
            case 6:
                out += 'sixty ';
                break;
            case 7:
                out += 'seventy ';
                break;
            case 8:
                out += 'eighty ';
                break;
            case 9:
                out += 'ninety ';
                break;
            case 0:
                out += '';
                break;

        }

        switch (+a[a.length - 1]) {
            case 1:
                out += 'one';
                break;
            case 2:
                out += 'two';
                break;
            case 3:
                out += 'three';
                break;
            case 4:
                out += 'four';
                break;
            case 5:
                out += 'five';
                break;
            case 6:
                out += 'six';
                break;
            case 7:
                out += 'seven';
                break;
            case 8:
                out += 'eight';
                break;
            case 9:
                out += 'nine';
                break;
        }
    }
    return out;
}

console.log(solve(['956']));
