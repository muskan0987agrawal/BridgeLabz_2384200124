
const readline = require("readline-sync");

let num = parseInt(readline.question("Enter a number: "));

function primeFactors(n) {
    let factors = [];

    // Divide by 2 until it's odd
    while (n % 2 === 0) {
        factors.push(2);
        n = n / 2;
    }

    // Check odd numbers from 3 onwards
    for (let i = 3; i * i <= n; i += 2) {
        while (n % i === 0) {
            factors.push(i);
            n = n / i;
        }
    }

    // If n is still greater than 2, it's a prime number
    if (n > 2) factors.push(n);

    return factors;
}

console.log(`Prime Factors of ${num}: ${primeFactors(num).join(", ")}`);
