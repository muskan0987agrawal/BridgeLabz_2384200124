const readline = require("readline-sync");

let num = parseInt(readline.question("Enter a number: "));

function factorial(n) {
    if (n < 0) return "Factorial is not defined for negative numbers.";
    let fact = 1;
    for (let i = 1; i <= n; i++) {
        fact *= i;
    }
    return fact;
}

console.log(`Factorial of ${num} is: ${factorial(num)}`);
