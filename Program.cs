class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        Console.WriteLine($"The largest property value in the list is {max}");
    }
}