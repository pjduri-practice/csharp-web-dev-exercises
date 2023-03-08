//Exercises: Control Flow & Collections

//TODO: Write your code for Dictionary Practice below:

Console.WriteLine("Hello, Dictionary!");

Dictionary<double, string> students = new Dictionary<double, string>();
string studentName;

Console.WriteLine("Enter student name Enter to finish.");
int studentId = 1;
do
{
    Console.WriteLine("Student: ");
    string input = Console.ReadLine();
    studentName = input;

    if (!Equals(studentName, ""))
    {
        students.Add(studentId, studentName);
        studentId++;
    }

} while (!Equals(studentName, ""));

// Print class roster
Console.WriteLine("\nClass roster:");

foreach (KeyValuePair<double, string> student in students)
{
    Console.WriteLine($"\nStudent name: {student.Value}");
    Console.WriteLine($"Student ID: {student.Key}");
}
