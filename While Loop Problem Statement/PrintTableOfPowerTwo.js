const readline = require("readline-sync");

let n = parseInt(readline.question("Enter the value of n: "));
let i = 0;
let power = 1;

while (i <= n && power <= 256) {
    console.log(`2^${i} = ${power}`);
    power *= 2;
    i++;
}
