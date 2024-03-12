// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        double average = CalculateAverage(numbers);
        Console.WriteLine("Average: " + average);
    }

    public static double CalculateAverage(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return (double)sum / array.Length;
    }
}
