const readline = require("readline-sync");

let num = parseInt(readline.question("Enter a number: "));

function isPrime(n) {
    if (n < 2) return false;
    for (let i = 2; i * i <= n; i++) {
        if (n % i === 0) return false;
    }
    return true;
}

console.log(`${num} is ${isPrime(num) ? "a Prime Number" : "not a Prime Number"}`);