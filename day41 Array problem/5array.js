//defining array for containing repeated digits
let repeatedDigitsArray= new Array();
let repeatedDigitsArrayUsingForLoop =new Array();
//getting the numbers with repeated digits in range of 0 to 100
for(let i=1;i<=100;i++)
{
    //array for adding digits for each element
    let numberDigits= new Array();
    let number=i;
    //iterating the loop until number is greater than 0 and adding elements in array
    while(number>0)
    {
        //taking the modulus
        var modulus= number%10;
        //converting modulus into string and adding it into array
        modulus= modulus.toString();
        numberDigits.push(modulus);
        //removing last digit from number
        number=Math.floor(number/10);
        //console.log(number);
    }
    //iterating elements of each numberdigits array and comparing with other elements
    //for loop method
    //comparing each element with another using for loop and adding no to array if there is match
    for(let j=0;j<numberDigits.length-1;j++)
    {
        for(let k=j+1;k<numberDigits.length;k++)
        {
            if (numberDigits[j]==numberDigits[k])
            {
                repeatedDigitsArrayUsingForLoop.push(i);
            }
        }
    }



    //getting repeated digits using array properties and using every and includes functions
    function checkForDigitMatch(n)
    {
        return n.includes(modulus);
    }
    //comparision is done only if array elements are greater than 1
    if(numberDigits.length>1)
    {
        if(numberDigits.every(checkForDigitMatch))
        {
        repeatedDigitsArray.push(i);
        }
    }
}
//this method gives result including 100
console.log("Repeated elements in array using for loop: "+repeatedDigitsArrayUsingForLoop);
// do not give result as 100
console.log("Array for repeated digits: "+repeatedDigitsArray);
