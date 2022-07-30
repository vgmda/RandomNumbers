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
            new PersonModel{FirstName = "Sophie"},
            new PersonModel{FirstName = "Mary"}
        };

        var sortedPeople = people.OrderBy(x => random.Next());

        foreach (var p in sortedPeople)
        {
            Console.WriteLine(p.FirstName);
        }

    }

    private static void SimpleMethod(Random random)
    {
        Console.WriteLine(random.Next());
    }


    //  Fisher-Yates shuffle
    //private static Random rng = new Random();

    //public static void Shuffle<T>(this IList<T> list)
    //{
    //    int n = list.Count;
    //    while (n > 1)
    //    {
    //        n--;
    //        int k = rng.Next(n + 1);
    //        T value = list[k];
    //        list[k] = list[n];
    //        list[n] = value;
    //    }
    //}

}

public class PersonModel
{
    public string FirstName { get; set; }
}