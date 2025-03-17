const readline = require("readline-sync");

let dayNum = parseInt(readline.question("Enter a number (1-7): "));

let days = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];

if (dayNum >= 1 && dayNum <= 7) {
    console.log("Day:", days[dayNum - 1]);  // Index 0 se start hota hai
} else {
    console.log("Invalid input! Enter a number between 1 and 7.");
}
