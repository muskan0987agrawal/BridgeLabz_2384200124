const readline = require("readline-sync");

let money = 100, goal = 200, bets = 0, wins = 0;

while (money > 0 && money < goal) {
    bets++;
    let betResult = Math.random() < 0.5; // 50% chance of winning

    if (betResult) {
        money++; // Win Rs 1
        wins++;
    } else {
        money--; // Lose Rs 1
    }
}

console.log(`Total Bets Made: ${bets}`);
console.log(`Total Wins: ${wins}`);
console.log(`Final Money: Rs ${money}`);
console.log(money === goal ? "You reached your goal!" : "You went broke!");
