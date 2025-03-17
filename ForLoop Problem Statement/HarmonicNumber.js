const readline = require("readline-sync");

// Taking input from command-line
let n = parseInt(readline.question("Enter the value of n: "));

if (isNaN(n) || n <= 0) {
    console.log("Please enter a valid positive integer.");
} else {
    let harmonicNumber = 0;
    
    for (let i = 1; i <= n; i++) {
        harmonicNumber += 1 / i;
    }

    console.log(`The ${n}th Harmonic Number is: ${harmonicNumber.toFixed(6)}`);
}
