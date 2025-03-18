// Function to generate birth months for 50 individuals
function generateBirthMonths() {
  let birthMonths = {};
  
  for (let i = 1; i <= 50; i++) {
      let month = Math.floor(Math.random() * 12) + 1;
      
      if (!birthMonths[month]) {
          birthMonths[month] = [];
      }
      birthMonths[month].push(`Person${i}`);
  }
  
  return birthMonths;
}

// Running the function and printing results
let birthMonthData = generateBirthMonths();
console.log("Individuals grouped by birth month:", birthMonthData);
