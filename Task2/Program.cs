
class Program
{
    static void Main()
    {
        var rand = new Random();
        var delegateArray = new[]
        {
            () => rand.Next(10),
            () => rand.Next(10),
            () => rand.Next(10)
        };

        double AverageMethod(IReadOnlyCollection<Func<int>> delegates)
        {
            var sum = delegates.Aggregate<Func<int>, double>(0, (current, del) => current + del());

            return sum / delegates.Count;
        }
        
        var average = AverageMethod(delegateArray);
        Console.WriteLine("The average of the random integers is: " + average);
    }
}