const readline = require("readline-sync");

let num = parseInt(readline.question("Enter a number (1, 10, 100, 1000, etc.): "));

let units = {
    1: "Unit",
    10: "Ten",
    100: "Hundred",
    1000: "Thousand",
    10000: "Ten Thousand",
    100000: "Lakh",
    1000000: "Million"
};

if (units[num]) {
    console.log("Place value:", units[num]);
} else {
    console.log("Invalid input! Enter valid values like 1, 10, 100, 1000...");
}
