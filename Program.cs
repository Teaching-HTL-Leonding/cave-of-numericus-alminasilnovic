var numbers = new int[1000000];
var newnumbers = new int[999999];
Random rand = new Random(4711);

for (int i = 0; i < 1000000; i++)
{
    numbers[i] = rand.Next(1, 1000000001);
}

Array.Sort(numbers);

for (int i = 1; i < numbers.Length; i++)
{
    newnumbers[i - 1] = numbers[i] - numbers[i - 1];
}

double average = newnumbers.Average();
Console.WriteLine($"average: {average}");