//defining console read write module for taking input from the user
io= require('console-read-write');
//making the function and declaring it async
//async makes the function execute when called and wait for user input statement
//if async is not defined then await can not be defined and all user inputs will be taken together
async function main()
{
    //defining array
    let numbersArray= new Array();
    //defining variable for checking triplets
    //not giving initial value to variable
    let checkForTriplet;
    console.log("Please enter the elements of array seperated by comma");
    //taking input for getting inputs
    let n= await io.read();
    //converting it into array
    numbersArray=n.split(",");
    //printing array
    console.log(numbersArray);
    //taking 1st element and compare it with every other element in forward direction
    for(let i=0;i<numbersArray.length-2;i++)
    {
        //choosing 2nd element and compare it with every element in forward direction
        for(let j=i+1;j<numbersArray.length-1;j++)
        {
            //choosing 3rd element and compare with 1st and 2nd element
            for(let k=j+1;k<numbersArray.length;k++)
            {
                //if sum of 3 selected integers is 0, then result is printed
                if(parseInt(numbersArray[i])+parseInt(numbersArray[k])+parseInt(numbersArray[j])==0)
                {
                    console.log("Triplet: "+numbersArray[i]+","+numbersArray[j]+","+numbersArray[k]);
                    checkForTriplet= true;

                }
            }
        }
    }
    //if no triplet exists, then this condition is executed
    if(!checkForTriplet)
    {
        console.log("Triplet for the given no's do not exists");
    }
}
main();
