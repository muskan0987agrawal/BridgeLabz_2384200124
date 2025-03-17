function isPalindrome(num) {
  let original = num.toString();
  let reversed = original.split('').reverse().join('');
  return original === reversed;
}

// Example usage
console.log(isPalindrome(121));  // true
console.log(isPalindrome(123));  // false
