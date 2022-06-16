let numArray = new Array();
for (let i = 1; i <= 10; i++) {
  let numbers = Math.floor(Math.random() * 900) + 100;
  numArray.push(numbers);
}
console.log("Input array : " + numArray);
let count = 0;
let max = numArray[0];
let min = numArray[0];

while (count < 10) {
  //for 1st max and min
  if (numArray[count] > max) {
    max = numArray[count];
  }
  if (numArray[count] < min) {
    min = numArray[count];
  }
  count++;
}
console.log("Min : " + min + " | Max : " + max);

let secondMin = max,
  mymin = max,
  secondMax = 1,
  co = 0;
while (co < 10) {
  //for 2nd max and min
  if (numArray[co] < max && numArray[co] > secondMax) {
    secondMax = numArray[co];
  }
  if (numArray[co] < mymin) {
    secondMin = mymin;
    mymin = numArray[co];
  }
  if (numArray[co] < secondMin && numArray[co] > mymin) {
    secondMin = numArray[co];
  }
  co++;
}
console.log("second Min : " + secondMin + " | second Max : " + secondMax);
