const readline = require("readline-sync");

let start = parseInt(readline.question("Enter the start of the range: "));
let end = parseInt(readline.question("Enter the end of the range: "));

function isPrime(n) {
    if (n < 2) return false;
    for (let i = 2; i * i <= n; i++) {
        if (n % i === 0) return false;
    }
    return true;
}

console.log(`Prime numbers between ${start} and ${end}:`);
for (let i = start; i <= end; i++) {
    if (isPrime(i)) {
        process.stdout.write(i + " ");
    }
}
console.log();
