// Function to find triplets that sum to zero
function findTripletsSumZero(arr) {
  let result = [];
  for (let i = 0; i < arr.length - 2; i++) {
      for (let j = i + 1; j < arr.length - 1; j++) {
          for (let k = j + 1; k < arr.length; k++) {
              if (arr[i] + arr[j] + arr[k] === 0) {
                  result.push([arr[i], arr[j], arr[k]]);
              }
          }
      }
  }
  return result;
}

let tripletArray = [-1, 0, 1, 2, -1, -4];
console.log("Triplets with sum zero:", findTripletsSumZero(tripletArray));