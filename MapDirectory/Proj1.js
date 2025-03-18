// Function to roll a die and get a number between 1 to 6
function rollDie() {
  return Math.floor(Math.random() * 6) + 1;
}

// Function to simulate die rolls until a number reaches 10 times
function simulateDiceRolls() {
  let rollCounts = [0, 0, 0, 0, 0, 0]; // Array to store count for each face (1-6)
  let maxRolls = 10;
  let reachedMax = false;
  let maxNum, minNum;

  while (!reachedMax) {
      let roll = rollDie();
      rollCounts[roll - 1]++;

      if (rollCounts[roll - 1] === maxRolls) {
          reachedMax = true;
      }
  }

  let maxIndex = 0, minIndex = 0;
  for (let i = 1; i < rollCounts.length; i++) {
      if (rollCounts[i] > rollCounts[maxIndex]) {
          maxIndex = i;
      }
      if (rollCounts[i] < rollCounts[minIndex]) {
          minIndex = i;
      }
  }

  maxNum = maxIndex + 1;
  minNum = minIndex + 1;

  return { rollCounts, maxNum, minNum };
}

// Running the simulation
let result = simulateDiceRolls();
console.log("Roll Die: ", rollDie());
console.log("Roll Counts:", result.rollCounts);
console.log("Number that reached maximum times:", result.maxNum);
console.log("Number that reached minimum times:", result.minNum);
