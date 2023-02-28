let numbers = [ 3, 14 , 90 , 30 ];
let sum = 0;
let count =0;

for (let i = 0; i < numbers.length; i++)
{
    if (numbers[i] % 3 == 0)
    {
         count++;
        sum+=numbers[i]

        }
        
    }
    console.log(Math.floor(sum/count));