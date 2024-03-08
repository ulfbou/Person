
namespace MyPerson;

internal class Program
{
    static void Main(string[] args)
    {
        // Creating a new instance of PersonHandler
        PersonHandler handler = new PersonHandler();

        try
        {
            /*
            // Creating a new person using its constructor.
            Person person1 = new Person("Jane", "Doe", 25, 101, 40.5);
            Console.WriteLine("Person created successfully!");

             person1.lName = "Ewing";         // Not accessible
             person1.fName = "Jock";          // Not accessible
             person1.age = 100;               // Not accessible
             person1.height = 175;            // Not accessible
             person1.weight = 85;             // Not accessible

            // Write information about the person. 
            PresentPerson(person1);
            */

            // Creating a new person using PersonHandler.
            Person person2 = handler.CreatePerson(30, "John", "Doe", 180.5, 75.0);
            Console.WriteLine("Person created successfully!");

            // Write information about the person. 
            PresentPerson(person2);

            // Setting age of the person
            handler.SetAge(person2, 35);
            handler.SetHeight(person2, person2.Height + 1.5);
            handler.SetWeight(person2, person2.Weight - 10.3);

            // Write information about the person. 
            PresentPerson(person2);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    // Writes information about person to the console. 
    private static void PresentPerson(Person person)
    {
        Console.WriteLine($"Person: {person.LName}, {person.FName}");
        Console.WriteLine($"Age: {person.Age}");
        Console.WriteLine($"Height: {person.Height} cm");
        Console.WriteLine($"Weight: {person.Weight} kg");
    }
}
