namespace MyPerson;

/// <summary>
/// Represents a person with basic information such as name, age, height, and weight.
/// </summary>
internal class Person
{
    private int age;
    private string fName;
    private string lName;
    private double height;
    private double weight;

    /// <summary>
    /// Gets or sets the first name of the person.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the provided first name is not within the allowed range (2 to 10 characters).</exception>
    public string FName
    {
        get => fName; 
        private set
        {
            if (value.Length >= 2 && value.Length <= 10)
            {
                fName = value;
            }
            else
            {
                throw new ArgumentException("First name must be between 2 and 10 characters long.");
            }
        }
    }

    /// <summary>
    /// Gets or sets the last name of the person.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the provided last name is not within the allowed range (3 to 15 characters).</exception>
    public string LName
    {
        get => lName; 
        private set
        {
            if (value.Length >= 3 && value.Length <= 15)
            {
                lName = value;
            }
            else
            {
                throw new ArgumentException("Last name must be between 3 and 15 characters long.");
            }
        }
    }

    /// <summary>
    /// Gets or sets the age of the person.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the provided age is not greater than 0.</exception>
    public int Age
    {
        get => age;
        set
        {
            if (value > 0)
            {
                age = value;
            }
            else
            {
                throw new ArgumentException("Age must be greater than 0.");
            }

        }
    }

    /// <summary>
    /// Gets or sets the height of the person.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the provided height is not greater than 0.</exception>
    public double Height
    {
        get { return height; }
        set
        {
            if (value > 0)
            {
                height = value;
            }
            else
            {
                throw new ArgumentException("Height must be greater than 0.");
            }
        }
    }

    /// <summary>
    /// Gets or sets the weight of the person.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the provided weight is not greater than 0.</exception>
    public double Weight
    {
        get { return weight; }
        set
        {
            if (value > 0)
            {
                weight = value;
            }
            else
            {
                throw new ArgumentException("Weight must be greater than 0.");
            }
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Person"/> class with the specified properties.
    /// </summary>
    /// <param name="fName">The first name of the person.</param>
    /// <param name="lName">The last name of the person.</param>
    /// <param name="age">The age of the person.</param>
    /// <paramf name="height">The height of the person in centimetres.</param>
    /// <param name="weight">The weight of the person in kilograms.</param>
    /// <exception cref="ArgumentException">
    /// Thrown when the provided first name, last name, or age do not meet the validation criteria.
    /// </exception>
    public Person(string fName, string lName, int age, double height, double weight)
    {
        FName = fName;
        LName = lName;
        Age = age;
        Height = height;
        Weight = weight;
    }
}
