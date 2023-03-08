//Exercises: Control Flow & Collections

//TODO: Write your code for Array Practice below:

Console.WriteLine("Hello, Arrays!");

int[] numArray = { 1, 1, 2, 3, 5, 8 };

foreach (int num in numArray)
{
    if (num % 2 > 0)
    {
        Console.WriteLine(num);
    }
}