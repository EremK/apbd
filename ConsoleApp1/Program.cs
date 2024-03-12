// See https://aka.ms/new-console-template for more information
public class Program // <-
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        
        double average = CalculateAverage(numbers);
        Console.WriteLine("Average: " + average);
        
        int max = FindMax(numbers);
        Console.WriteLine("Maximum value: " + max);
    }

    public static double CalculateAverage(int[] array)
    {
        int sum123 = 0;
        foreach (int num in array)
        {
            sum123 += num;
        }
        
        return (double)sum123 / array.Length;
    }
    
    // Function to find maximum number in the array
    public static int FindMax(int[] array)
    {
        int max = array[0];
        
        foreach (int num in array)
        {
            if (num > max)
            {
                max = num;
            }
        }

        return max;
    }
}
