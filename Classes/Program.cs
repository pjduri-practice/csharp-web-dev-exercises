// TODO: Instantiate your objects and test your exercise solutions with print statements here.
using Classes;
using System.Reflection;

Student whateverTheNewName = new Student("Dion", 111, 1, 4.0);

Student rosco = new Student("Rosco", 323);

//Console.WriteLine(whateverTheNewName.Name);
//whateverTheNewName.Name = "D";
//Console.WriteLine(whateverTheNewName.Name);

Student joe = new Student("Joe");
Student rob = new Student("Rob");
Student jak = new Student("Jak");
Student bill = new Student("Bill");

//Console.WriteLine(joe.StudentId);
//Console.WriteLine(rob.StudentId);
//Console.WriteLine(jak.StudentId);
//Console.WriteLine(bill.StudentId);
PropertyInfo[] info;

info = bill.GetType().GetProperties();

for (int i = 0; i < info.Length; i++)
{
    Console.WriteLine(info[i].ToString());
}

public IEnumerator<PropertyInfo> GetEnumerator()
{
    foreach (var property in typeof(Student).GetProperties())
    {
        yield return property;
    }
}