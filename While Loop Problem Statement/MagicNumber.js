const readline = require("readline-sync");

console.log("Think of a number between 1 and 100.");
let low = 1, high = 100, magicNumber = 0;

while (low <= high) {
    let mid = Math.floor((low + high) / 2);
    let response = readline.question(`Is your number ${mid}? (yes/higher/lower): `).toLowerCase();

    if (response === "yes") {
        magicNumber = mid;
        break;
    } else if (response === "higher") {
        low = mid + 1;
    } else if (response === "lower") {
        high = mid - 1;
    } else {
        console.log("Invalid response. Please enter 'yes', 'higher', or 'lower'.");
    }
}

console.log(`Your Magic Number is: ${magicNumber}`);
