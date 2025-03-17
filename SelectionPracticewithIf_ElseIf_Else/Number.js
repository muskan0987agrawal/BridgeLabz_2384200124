
const readline = require("readline-sync");

let num = parseInt(readline.question("Enter a single digit (0-9): "));

let words = ["Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"];

if (num >= 0 && num <= 9) {
    console.log("In words:", words[num]);
} else {
    console.log("Invalid input! Enter a single digit (0-9).");
}
