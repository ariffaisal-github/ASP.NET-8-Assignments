using System;

class Assignment
{
    static void Main()
    {
        Console.WriteLine("----------------------- Task-2 -------------------------");
        Console.WriteLine("Enter 10 numbers: ");
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The numbers you entered are: ");
        foreach (int number in arr)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine("\n\n----------------------- Task-3(a) -------------------------");

        int[] randomNums = new int[3];
        Random random = new Random();
        randomNums[0] = random.Next(1, 1000);
        randomNums[1] = random.Next(1, 1000);
        randomNums[2] = random.Next(1, 1000);
        Console.Write("The random numbers generated are: ");
        foreach (int number in randomNums)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine("\n\n");

        /* ------- Finding the largest number using if-else --------------*/
        int largest = randomNums[0];
        if (randomNums[1] > largest)
            largest = randomNums[1];

        if (randomNums[2] > largest)
            largest = randomNums[2];

        Console.WriteLine("The largest number is: " + largest);

        Console.WriteLine("\n\n----------------------- Task-3(b) -------------------------");

        /* ------- Finding the smallest number using switch  --------------*/

        int smallest = randomNums[0];
        // Compare with second number
        switch (smallest)
        {
            case var n when randomNums[1] < n:
                smallest = randomNums[1];
                break;
        }

        // Compare with third number
        switch (smallest)
        {
            case var n when randomNums[2] < n:
                smallest = randomNums[2];
                break;
        }

        // Print using switch statements

        switch(smallest)
        {
            case int n when randomNums[0] == n:
                Console.WriteLine("At 0th index, The smallest number is: " + randomNums[0]);
                break;
            case int n when randomNums[1] == n:
                Console.WriteLine("At 1st index, The smallest number is: " + randomNums[1]);
                break;
            case int n when randomNums[2] == n:
                Console.WriteLine("At 2nd index, The smallest number is: " + randomNums[2]);
                break;
            default:
                break;
        }
    }
}
