//defining array
let randomNumberArray= new Array();
//iterating until length of array is 10
while(randomNumberArray.length<10)
{
    //taking random numbers
    randomNumber= Math.floor(Math.random()*1000);
    //if no. is in correct range, then pushing it in array
    if(randomNumber>=100 && randomNumber<=999)
    {
        randomNumberArray.push(randomNumber);
    }
}
let unsortedArray= randomNumberArray;
console.log(randomNumberArray);
//sorting array
//iterating the loop 10 times 
for(let iteration=0;iteration<randomNumberArray.length;iteration++)
{
    //iterating the loop and changing position of elements by comparing to each other
    //same is done 10 times to get sorted array
for(let count=0;count<randomNumberArray.length-1;count++)
{
    if(randomNumberArray[count]>randomNumberArray[count+1])
    {
        let x= randomNumberArray[count];
        randomNumberArray[count]= randomNumberArray[count+1];
        randomNumberArray[count+1]= x;
    }
}
}
//printing 2nd largest and 2nd smallest elements
console.log(randomNumberArray);
console.log("Second largest element: "+randomNumberArray[8]);
console.log("Second smallest element: "+randomNumberArray[1]);
//sorting directly by sort function
unsortedArray.sort();
console.log(unsortedArray);
