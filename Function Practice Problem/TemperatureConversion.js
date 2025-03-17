const readline = require("readline-sync");

console.log("Select Conversion: \n1. Celsius to Fahrenheit \n2. Fahrenheit to Celsius");
let choice = parseInt(readline.question("Enter choice (1/2): "));

switch (choice) {
    case 1:
        let degC = parseFloat(readline.question("Enter temperature in Celsius: "));
        if (degC >= 0 && degC <= 100) {
            let degF = (degC * 9 / 5) + 32;
            console.log(`${degC}°C = ${degF.toFixed(2)}°F`);
        } else {
            console.log("Temperature out of valid range (0°C to 100°C)");
        }
        break;

    case 2:
        let degF = parseFloat(readline.question("Enter temperature in Fahrenheit: "));
        if (degF >= 32 && degF <= 212) {
            let degC = (degF - 32) * 5 / 9;
            console.log(`${degF}°F = ${degC.toFixed(2)}°C`);
        } else {
            console.log("Temperature out of valid range (32°F to 212°F)");
        }
        break;

    default:
        console.log("Invalid choice. Select either 1 or 2.");
}
