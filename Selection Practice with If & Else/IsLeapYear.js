const readline = require("readline"); //import the readline module

// Create an interface to read input from the terminal
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

// Ask the user for input
rl.question("Enter a 4-digit year: ", function(year) {
    year = parseInt(year); // Convert input to number

    // Leap year condition
    if ((year % 4 === 0 && year % 100 !== 0) || (year % 400 === 0)) {
        console.log(year + " is a Leap Year.");
    } else {
        console.log(year + " is NOT a Leap Year.");
    }

    rl.close(); // Close the input stream
});
