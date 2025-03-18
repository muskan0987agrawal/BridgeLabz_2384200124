// Function to generate 10 random 3-digit numbers
function generateRandomNumbers() {
    let numbers = [];
    for (let i = 0; i < 10; i++) {
        numbers.push(Math.floor(Math.random() * 900) + 100);
    }
    return numbers;
}

// Function to find the 2nd largest and 2nd smallest without sorting
function findSecondLargestSmallest(arr) {
    let largest = -Infinity, secondLargest = -Infinity;
    let smallest = Infinity, secondSmallest = Infinity;
    
    for (let num of arr) {
        if (num > largest) {
            secondLargest = largest;
            largest = num;
        } else if (num > secondLargest && num !== largest) {
            secondLargest = num;
        }

        if (num < smallest) {
            secondSmallest = smallest;
            smallest = num;
        } else if (num < secondSmallest && num !== smallest) {
            secondSmallest = num;
        }
    }
    return { secondLargest, secondSmallest };
}

// Function to sort the array and find 2nd largest & 2nd smallest
function findSecondLargestSmallestSorted(arr) {
    let sortedArr = [...arr].sort((a, b) => a - b);
    return { secondLargest: sortedArr[sortedArr.length - 2], secondSmallest: sortedArr[1] };
}




let randomNumbers = generateRandomNumbers();
console.log("Random Numbers:", randomNumbers);
console.log("Without Sorting:", findSecondLargestSmallest(randomNumbers));
console.log("With Sorting:", findSecondLargestSmallestSorted(randomNumbers));



