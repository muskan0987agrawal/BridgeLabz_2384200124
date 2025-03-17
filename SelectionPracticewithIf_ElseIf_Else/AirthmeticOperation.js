const readline = require("readline-sync");

let a = parseInt(readline.question("Enter first number (a): "));
let b = parseInt(readline.question("Enter second number (b): "));
let c = parseInt(readline.question("Enter third number (c): "));

let operations = {
    "a + b * c": a + b * c,
    "c + a / b": c + a / b,
    "a % b + c": a % b + c,
    "a * b + c": a * b + c
};

let values = Object.values(operations);
let max = Math.max(...values);
let min = Math.min(...values);

console.log("Results:", operations);
console.log("Maximum value:", max);
console.log("Minimum value:", min);
