// Function to get prime factors of a number
function getPrimeFactors(n) {
  let factors = [];
  for (let i = 2; i < n; i++) {
      while (n % i === 0) {
          factors.push(i);
          n /= i;
      }
  }
  return factors;
}

let number = 100;
console.log("Prime Factors of", number, getPrimeFactors(number));