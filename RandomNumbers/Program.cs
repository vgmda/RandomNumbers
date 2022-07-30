namespace RandomNumbers;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        //for (int i = 0; i < 10; i++)
        //{
        //    //SimpleMethod(random);
        //    Console.WriteLine(random.NextDouble() * 10);
        //}

        List<PersonModel> people = new List<PersonModel>
        {
            new PersonModel{FirstName = "Sue"},
            new PersonModel{FirstName = "Bob"},
            new PersonModel{FirstName = "David"},
            new PersonModel{FirstName = "Arnold"},
            new PersonModel{FirstName = "Jack"},
            new PersonModel{FirstName = "Zoe"},
            new PersonModel{FirstName = "Sophie"}
        };


    }

    private static void SimpleMethod(Random random)
    {
        Console.WriteLine(random.Next());
    }

}

public class PersonModel
{
    public string FirstName { get; set; }
}