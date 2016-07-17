function solve(args) {
    var a = args[0], out = '';

    if (+a === 0) {
        return 'Zero';
    }
    switch (+a[a.length - 3]) {
        case 1:
            out += 'One hundred and ';
            break;
        case 2:
            out += 'Two hundred and ';
            break;
        case 3:
            out += 'Three hundred and ';
            break;
        case 4:
            out += 'Four hundred and ';
            break;
        case 5:
            out += 'Five hundred and ';
            break;
        case 6:
            out += 'Six hundred and ';
            break;
        case 7:
            out += 'Seven hundred and ';
            break;
        case 8:
            out += 'Eight hundred and ';
            break;
        case 9:
            out += 'Nine hundred and ';
            break;
        default:
            out += '';

    }

    if (a[a.length - 2] <= 2) {
        switch (+(a[a.length - 2].concat(a[a.length - 1]))) {
            case 0:
                out += 'Zero';
                break;
            case 1:
                out += 'One';
                break;
            case 2:
                out += 'Two';
                break;
            case 3:
                out += 'Three';
                break;
            case 4:
                out += 'Four';
                break;
            case 5:
                out += 'Five';
                break;
            case 6:
                out += 'Six';
                break;
            case 7:
                out += 'Seven';
                break;
            case 8:
                out += 'Eight';
                break;
            case 9:
                out += 'Nine';
                break;
            case 10:
                out += 'Ten';
                break;
            case 11:
                out += 'Eleven';
                break;
            case 12:
                out += 'Twelve';
                break;
            case 13:
                out += 'Thirteen';
                break;
            case 14:
                out += 'Fourteen';
                break;
            case 15:
                out += 'Fifteen';
                break;
            case 16:
                out += 'Sixteen';
                break;
            case 17:
                out += 'Seventeen';
                break;
            case 18:
                out += 'Eighteen';
                break;
            case 19:
                out += 'Nineteen';
                break;
            case 20:
                out += 'Twenty';
                break;
        }
    } else {
        switch (+a[a.length - 2]) {
            case 3:
                out += 'Thirty ';
                break;
            case 4:
                out += 'Fourty ';
                break;
            case 5:
                out += 'Fifty ';
                break;
            case 6:
                out += 'Sixty ';
                break;
            case 7:
                out += 'Seventy ';
                break;
            case 8:
                out += 'Eighty ';
                break;
            case 9:
                out += 'Ninety ';
                break;
            case 0:
                out += '';
                break;

        }

        switch (+a[a.length - 1]) {
            case 1:
                out += 'One';
                break;
            case 2:
                out += 'Two';
                break;
            case 3:
                out += 'Three';
                break;
            case 4:
                out += 'Four';
                break;
            case 5:
                out += 'Five';
                break;
            case 6:
                out += 'Six';
                break;
            case 7:
                out += 'Seven';
                break;
            case 8:
                out += 'Eight';
                break;
            case 9:
                out += 'Nine';
                break;
        }
    }
    return out;
}

console.log(solve(['956']));
