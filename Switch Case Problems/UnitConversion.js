console.log("Choose conversion:\n1. Feet to Inch\n2. Feet to Meter\n3. Inch to Feet\n4. Meter to Feet");
let choice = parseInt(readline.question("Enter your choice (1-4): "));
let value = parseFloat(readline.question("Enter the value to convert: "));

switch (choice) {
    case 1: console.log(`${value} feet = ${value * 12} inches`); break;
    case 2: console.log(`${value} feet = ${value * 0.3048} meters`); break;
    case 3: console.log(`${value} inches = ${value / 12} feet`); break;
    case 4: console.log(`${value} meters = ${value * 3.28084} feet`); break;
    default: console.log("Invalid choice! Please enter a number between 1 and 4.");
}
