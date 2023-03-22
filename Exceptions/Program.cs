// --------- Divide By Zero! ----------


using System.Drawing;
using System;

static double Divide(double x, double y)
{
    // Write your code here!
    if (y == 0)
    {
        // TODO: Google nameof keyword
        throw new ArgumentOutOfRangeException(nameof(y), "You can't divide by zero!");
    }
    else
    {
        return x / y;
    }
    //try
    //{
    //    return x / y;
    //} catch (Exception e)
    //{
    //    throw new ArgumentOutOfRangeException("You can't divide by zero!");
    //}
}

// Test out your Divide() function here!
//Console.WriteLine(Divide(4, 0));

// --------- Test Student Labs ----------


static int CheckFileExtension(string fileName)
{
    // Write your code here!
    // Return an integer representing the number of points a
    // student receives for properly submitting a file in C#.
    //If a student’s submitted file ends in .cs, they get 1 point.

    //If a student’s submitted file doesn’t end in .cs, they get 0 points.
    //If a student’s submitted file doesn’t end in .cs, they get 0 points.
    if (fileName.EndsWith(".cs"))
    {
        return 1;
    }

    //If the file submitted is null or an empty string, an
    //exception should be thrown.What kind of exception is up to you!    
    if (fileName == null || fileName == "")
    {
        throw new ArgumentNullException(nameof(fileName), "Student did not submit work");
    }

    return 0;
}

// Test out your CheckFileExtension() function here!

Dictionary<string, string> students = new Dictionary<string, string>();
students.Add("Carl", "Program.cs");
students.Add("Brad", "");
students.Add("Elizabeth", "MyCode.cs");


Console.WriteLine(CheckFileExtension(students["Brad"]));


