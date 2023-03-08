//Exercises: Control Flow & Collections

//TODO: Write your code for List Practice below:
using System.Linq;

Console.WriteLine("Hello, Lists!");

static double findSum(List<double> numbers)
{
    double sum = 0;
    foreach (double number in numbers)
    {
        if (number % 2 == 0)
        {
            sum += number;

        }
    }
    return sum;
}

List<double> numList = new() {1,3,7,1,88,54,33,7,12,7,9};

Console.WriteLine(findSum(numList));

String seuss = "I would not could not in a box I would not could not with a fox I will not eat them in a house I will not eat them with a mouse";

List<string> eggs;
eggs = seuss.Split().ToList();

Console.WriteLine("Enter a word length: ");
int wordLength = int.Parse(Console.ReadLine());

foreach (string word in eggs)
{
    if (word.Length == wordLength)
    {
        Console.WriteLine(word);
    }
}