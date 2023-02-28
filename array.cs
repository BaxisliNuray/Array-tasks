//1.Arrayde 3-e bolunen ededlerin ededi ortasini tapin

int[] numbers = { 3, 14 , 90 , 30 };
int sum = 0;
int count =0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 3 == 0)
    {
        count++;
        sum += numbers[i];

    }    
 
}
Console.WriteLine(sum/count);


//2.Reqemlerinin sayi 2-den boyuk olan ededlerin cemini tap

int[] reqemler = { 23, 56, 123, 784, 3, 56, 1000 };
int topla = 0;
for(int i = 0;i < reqemler.Length; i++)
{
    if (reqemler[i] > 99)
    {
        topla += reqemler[i];
    }
}
Console.WriteLine(topla);
                      

//3.En boyuk eded(max) ve en kicik ededin(min) ededi ortasini tap

int[] nums = { 17, 3, 4, 2, 9 };
int max= nums[0];
int min= nums[0];
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > max)
    {
    max = nums[i];
    }
    if (nums[i] < min)
    {
        min = nums[i];
    }
}
Console.WriteLine((max+min)/2);

//4. adi 'A' herfi ile baslayanlarin sayini tapin
string[] names = { "Irada", "Akif", "Fidan", "Amalia", "Anar" };
int counter = 0;
for(int i=0; i < names.Length; i++)
{
    if (names[i].StartsWith("A")) {   //StartWith("A") adi A ile baslayan sozleri secir (tesadufen tapdin unutma!! )
        counter++;
    }
}
    Console.WriteLine(counter);





