let numbers = [23, 56, 123, 784, 3, 56, 1000 ];
let sum = 0;
for(let i = 0;i < numbers.length; i++)
{
    if (numbers[i] > 99)
    {
        sum += numbers[i];
    }
}
console.log(sum);