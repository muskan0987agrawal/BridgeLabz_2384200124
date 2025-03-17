// a. Convert 42 inches to feet
console.log("42 inches in feet:", 42 / 12);

// b. Convert Rectangular Plot (60 feet x 40 feet) to meters
let lengthFeet = 60, widthFeet = 40;
let feetToMeter = 0.3048; // 1 foot = 0.3048 meters
console.log("Rectangular Plot in meters:", lengthFeet * feetToMeter, "x", widthFeet * feetToMeter);

// c. Calculate area of 25 such plots in acres
let areaOnePlotMeters = (lengthFeet * feetToMeter) * (widthFeet * feetToMeter);
console.log("Total area of 25 plots in acres:", areaOnePlotMeters * 25 * 0.000247105);
