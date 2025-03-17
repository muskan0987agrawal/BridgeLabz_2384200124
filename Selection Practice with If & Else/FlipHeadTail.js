const readline = require("readline");

// Create an interface to read input
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

// Ask user to press Enter to flip the coin
rl.question("Press Enter to flip the coin...", function() {
    let randomValue = Math.floor(Math.random() * 2); // Generates 0 or 1
    let result = (randomValue === 0) ? "Heads" : "Tails"; // Assigns Heads or Tails
    
    console.log("Result: " + result);

    rl.close(); // Close the input stream
});
