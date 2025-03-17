// Generate 5 random three-digit numbers (100 to 999)
let num1 = Math.floor(Math.random() * 900) + 100;
let num2 = Math.floor(Math.random() * 900) + 100;
let num3 = Math.floor(Math.random() * 900) + 100;
let num4 = Math.floor(Math.random() * 900) + 100;
let num5 = Math.floor(Math.random() * 900) + 100;

console.log("Generated Numbers:", num1, num2, num3, num4, num5);

// Find the minimum and maximum using if-else
let min = num1;
let max = num1;

// Check for minimum value
if (num2 < min) min = num2;
else if (num3 < min) min = num3;
else if (num4 < min) min = num4;
else min = num5;

// Check for maximum value
if (num2 > max) max = num2;
else if (num3 > max) max = num3;
else if (num4 > max) max = num4;
else max = num5;

// Print the results
console.log("Minimum Value:", min);
console.log("Maximum Value:", max);



