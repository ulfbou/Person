namespace MyPerson;

internal class PersonHandler
{
    /// <summary>
    /// Creates a new person with the specified properties.
    /// </summary>
    /// <param name="age">The age of the person.</param>
    /// <param name="fName">The first name of the person.</param>
    /// <param name="lName">The last name of the person.</param>
    /// <param name="height">The height of the person.</param>
    /// <param name="weight">The weight of the person.</param>
    /// <returns>A new instance of the Person class.</returns>
    public Person CreatePerson(int age, string fName, string lName, double height, double weight)
    {
        return new Person(fName, lName, age, height, weight);
    }

    /// <summary>
    /// Sets the age of the specified person.
    /// </summary>
    /// <param name="person">The person whose age needs to be set.</param>
    /// <param name="newAge">The new age value.</param>
    /// <exception cref="ArgumentException">
    /// Thrown when the new age value is not greater than 0.
    /// </exception>
    public void SetAge(Person person, int newAge)
    {
        person.Age = newAge;
    }

    /// <summary>
    /// Sets the first name of the specified person.
    /// </summary>
    /// <param name="person">The person whose first name needs to be set.</param>
    /// <param name="newFName">The new first name value.</param>
    /// <exception cref="ArgumentException">
    /// <exception cref="ArgumentException">Thrown when the provided first name is not within the allowed range (2 to 10 characters).</exception>
    public void SetFName(Person person, string newFName)
    {
        //person.FName = newFName;
    }

    /// <summary>
    /// Sets the height of the specified person.
    /// </summary>
    /// <param name="person">The person whose last name needs to be set.</param>
    /// <param name="newHeight">The new height value.</param>
    /// <exception cref="ArgumentException">Thrown when the provided weight is not greater than 0.</exception>
    public void SetHeight(Person person, double newHeight)
    {
        person.Height = newHeight;
    }

    /// <summary>
    /// Sets the weight of the specified person.
    /// </summary>
    /// <param name="person">The person whose last name needs to be set.</param>
    /// <param name="newweight">The new weight value.</param>
    /// <exception cref="ArgumentException">Thrown when the provided weight is not greater than 0.</exception>
    public void SetWeight(Person person, double newWeight)
    {
        person.Height = newWeight;
    }
}