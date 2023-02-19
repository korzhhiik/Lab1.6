class Program
{
    static void Main()
    {
        double AverageMethod(int arg1, int arg2, int arg3)
        {
            double sum = arg1 + arg2 + arg3;
            return sum / 3;
        }

        var average = AverageMethod(2, 4, 6);
        Console.WriteLine("The average of 2, 4, and 6 is: " + average);
    }
}